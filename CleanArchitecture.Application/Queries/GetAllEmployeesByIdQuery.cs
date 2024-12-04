using CleanArchitecture.Domain.Entities;
using CleanArchitecture.Domain.Interface;
using MediatR;

namespace CleanArchitecture.Application.Queries
{
    public record GetAllEmployeesByIdQuery(Guid EmployeeId) : IRequest<EmployeeEntity>;
    public class GetAllEmployeesByIdQueryHandler(IEmployeeRepository employeeRepository) : IRequestHandler<GetAllEmployeesByIdQuery, EmployeeEntity>
    {
        public async Task<EmployeeEntity> Handle(GetAllEmployeesByIdQuery request, CancellationToken cancellationToken)
        {
            return await employeeRepository.GetEmployeesById(request.EmployeeId);
        }
    }
}
