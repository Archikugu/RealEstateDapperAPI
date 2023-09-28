using Dapper;
using RealEstateDapperAPI.Dtos.EmployeeDtos;
using RealEstateDapperAPI.Models.DapperContext;

namespace RealEstateDapperAPI.Repositories.EmployeeRepositories
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly Context _context;

        public EmployeeRepository(Context context)
        {
            _context = context;
        }

        public async void CreateEmployee(CreateEmployeeDto createEmployeeDto)
        {
            string query = "insert into Employee (EmployeeName,EmployeeTitle,EmployeeMail,EmployeePhoneNumber,ImageUrl,Status) values (@employeeName,@employeeTitle,@employeeMail,@employeePhoneNumber,@imageUrl,@status)";
            var parameters = new DynamicParameters();
            parameters.Add("@employeeName", createEmployeeDto.EmployeeName);
            parameters.Add("@employeeTitle", createEmployeeDto.EmployeeTitle);
            parameters.Add("@employeeMail", createEmployeeDto.EmployeeMail);
            parameters.Add("@employeePhoneNumber", createEmployeeDto.EmployeePhoneNumber);
            parameters.Add("@imageUrl", createEmployeeDto.ImageUrl);
            parameters.Add("@status", true);

            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
            }
        }

        public async void DeleteEmployee(int id)
        {
            string query = "delete from Employee where EmployeeID = @employeeID";
            var parameters = new DynamicParameters();
            parameters.Add("@employeeID", id);
            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
            }
        }

        public async Task<List<ResultEmployeeDto>> GetAllEmployeeAsync()
        {
            string query = "select * from Employee";
            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryAsync<ResultEmployeeDto>(query);
                return values.ToList();
            };
        }

        public async Task<GetByIDEmployeeDto> GetEmployee(int id)
        {
            string query = "select * from employee where EmployeeID = @employeeID";
            var parameters = new DynamicParameters();
            parameters.Add("@employeeID", id);
            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryFirstOrDefaultAsync<GetByIDEmployeeDto>(query, parameters);
                return values;
            }
        }

        public async void UpdateEmployee(UpdateEmployeeDto updateEmployeeDto)
        {
            string query = "update Employee set EmployeeName=@employeeName,EmployeeTitle=@employeeTitle,EmployeeMail=@employeeMail,EmployeePhoneNumber=@employeePhoneNumber,ImageUrl=@imageUrl,Status=@status where EmployeeID=@employeeID";
            var parameters = new DynamicParameters();
            parameters.Add("@employeeName", updateEmployeeDto.EmployeeName);
            parameters.Add("@employeeTitle", updateEmployeeDto.EmployeeTitle);
            parameters.Add("@employeeMail", updateEmployeeDto.EmployeeMail);
            parameters.Add("@employeePhoneNumber", updateEmployeeDto.EmployeePhoneNumber);
            parameters.Add("@imageUrl", updateEmployeeDto.ImageUrl);
            parameters.Add("@status", updateEmployeeDto.Status);
            parameters.Add("@employeeID", updateEmployeeDto.EmployeeID);

            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
            }
        }
    }
}
