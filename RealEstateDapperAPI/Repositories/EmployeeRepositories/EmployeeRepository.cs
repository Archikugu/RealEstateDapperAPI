using RealEstateDapperAPI.Dtos.EmployeeDtos;

namespace RealEstateDapperAPI.Repositories.EmployeeRepositories
{
    public class EmployeeRepository : IEmployeeRepository
    {
        public void CreateEmployee(CreateEmployeeDto createEmployeeDto)
        {
            throw new NotImplementedException();
        }

        public void DeleteEmployee(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<ResultEmployeeDto>> GetAllEmployeeAsync()
        {
            throw new NotImplementedException();
        }

        public Task<GetByIDEmployeeDto> GetEmployee(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateEmployee(UpdateEmployeeDto updateEmployeeDto)
        {
            throw new NotImplementedException();
        }
    }
}
