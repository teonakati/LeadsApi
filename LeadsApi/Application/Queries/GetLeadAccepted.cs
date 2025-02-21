using LeadsApi.Application.Commands;
using MediatR;

namespace LeadsApi.Application.Queries
{
    public class GetLeadAccepted : IRequest<List<LeadAcceptedResponse>>
    {
    }
}
