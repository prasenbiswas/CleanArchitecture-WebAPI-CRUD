using CleanArchitecture.Domain.Entities;
using CleanArchitecture.Domain.Interface;
using CleanArchitecture.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace CleanArchitecture.Infrastructure.Repository
{
    public class EmployeeRepository(ApplicationDbContext dbContext) : IEmployeeRepository
    {
        public async Task<IEnumerable<EmployeeEntity>> GetEmployees()
        {
            return await dbContext.Employees.ToListAsync();
        }
        public async Task<EmployeeEntity> GetEmployeesById(Guid employeeId)
        {
            return await dbContext.Employees.FirstOrDefaultAsync(x => x.Id == employeeId);
        }
        public async Task<EmployeeEntity> AddEmployee(EmployeeEntity entity)
        {
            entity.Id = Guid.NewGuid();
            dbContext.Add(entity);
            await dbContext.SaveChangesAsync();
            return entity;
        }
        public async Task<EmployeeEntity> UpdateEmployee(Guid employeeId, EmployeeEntity entity)
        {
            var employee = await dbContext.Employees.FirstOrDefaultAsync(x => x.Id == employeeId);
            if (employee != null)
            {
                employee.Name = entity.Name;
                employee.Email = entity.Email;
                employee.Phone = entity.Phone;
                await dbContext.SaveChangesAsync();
                return employee;
            }
            return entity;
        }
        public async Task<bool> DeleteEmployee(Guid employeeId)
        {
            var employee = await dbContext.Employees.FirstOrDefaultAsync(x => x.Id == employeeId);
            if (employee != null)
            {
                dbContext.Employees.Remove(employee);
                return await dbContext.SaveChangesAsync() > 0;
            }
            return false;
        }
    }
}
