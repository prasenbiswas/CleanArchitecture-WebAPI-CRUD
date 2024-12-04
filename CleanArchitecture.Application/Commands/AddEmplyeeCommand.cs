using CleanArchitecture.Domain.Entities;
using CleanArchitecture.Domain.Interface;
using MediatR;

namespace CleanArchitecture.Application.Commands
{
    public record AddEmplyeeCommand(EmployeeEntity Employee) : IRequest<EmployeeEntity>;
    public class AddEmplyeeCommandHandler(IEmployeeRepository employeeRepository) : IRequestHandler<AddEmplyeeCommand, EmployeeEntity>
    {
        public async Task<EmployeeEntity> Handle(AddEmplyeeCommand request, CancellationToken cancellationToken)
        {
            return await employeeRepository.AddEmployee(request.Employee);
        }
    }
}
