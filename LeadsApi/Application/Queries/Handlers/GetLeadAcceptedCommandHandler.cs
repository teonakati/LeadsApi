using LeadsApi.Domain.Interfaces;
using MediatR;

namespace LeadsApi.Application.Queries.Handlers
{
    public class GetLeadAcceptedCommandHandler : IRequestHandler<GetLeadAccepted, List<LeadAcceptedResponse>>
    {
        private readonly ILeadRepository _repository;

        public GetLeadAcceptedCommandHandler(ILeadRepository leadRepository)
        {
            _repository = leadRepository;
        }
        public Task<List<LeadAcceptedResponse>> Handle(GetLeadAccepted request, CancellationToken cancellationToken)
        {
            var result = _repository.GetAcceptedLeads().Result;
            return Task.FromResult(result);
        }
    }
}
