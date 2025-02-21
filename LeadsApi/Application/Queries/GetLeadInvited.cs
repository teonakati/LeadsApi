using MediatR;

namespace LeadsApi.Application.Queries
{
    public class GetLeadInvited : IRequest<List<LeadInvitedResponse>>
    {
    }
}
