using CleanArchitecture.Domain.Entities;

namespace CleanArchitecture.Domain.Interface
{
    public interface IEmployeeRepository
    {
        Task<IEnumerable<EmployeeEntity>> GetEmployees();
        Task<EmployeeEntity> GetEmployeesById(Guid id);
        Task<EmployeeEntity> AddEmployee(EmployeeEntity employee);
        Task<EmployeeEntity> UpdateEmployee(Guid employeeId, EmployeeEntity entity);
        Task<bool> DeleteEmployee(Guid employeeId);
    }
}
