using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.LeaveManagement.Application.Features.LeaveType.Queries.GetAllLeaveTypes
{
    /* public class GetLeaveTypesQuery : IRequest<List<LeaveTypeDto>>
     {

     }*/

    // Difference between class and record is that record is immutable and it is a value type and it is a reference type 
    // Class is a reference type and it is mutable and it is a value type

    public record GetLeaveTypesQuery : IRequest<List<LeaveTypeDto>>;
}
