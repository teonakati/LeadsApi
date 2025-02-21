using LeadsApi.Domain.Interfaces;
using MediatR;

namespace LeadsApi.Application.Queries.Handlers
{
    public class GetLeadInvitedCommandHandler : IRequestHandler<GetLeadInvited, List<LeadInvitedResponse>>
    {
        private readonly ILeadRepository _repository;

        public GetLeadInvitedCommandHandler(ILeadRepository leadRepository)
        {
            _repository = leadRepository;
        }
        public Task<List<LeadInvitedResponse>> Handle(GetLeadInvited request, CancellationToken cancellationToken)
        {
            var result = _repository.GetInvitedLeads().Result;
            return Task.FromResult(result);
        }
    }
}
