using RealEstateDapperAPI.Dtos.EmployeeDtos;

namespace RealEstateDapperAPI.Repositories.EmployeeRepositories
{
    public interface IEmployeeRepository
    {
        Task<List<ResultEmployeeDto>> GetAllEmployee();
        void CreateEmployee(CreateEmployeeDto createEmployeeDto);
        void UpdateEmployee(UpdateEmployeeDto updateEmployeeDto);
        void DeleteEmployee(int id);
        Task<GetByIDEmployeeDto> GetEmployee(int id);
    }
}
