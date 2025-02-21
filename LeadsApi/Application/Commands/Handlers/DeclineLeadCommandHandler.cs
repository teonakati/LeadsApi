using LeadsApi.Domain.Interfaces;
using MediatR;

namespace LeadsApi.Application.Commands.Handlers
{
    public class DeclineLeadCommandHandler : IRequestHandler<DeclineLeadRequest, bool>
    {
        private readonly ILeadRepository _repository;

        public DeclineLeadCommandHandler(ILeadRepository leadRepository)
        {
            _repository = leadRepository;
        }
        public Task<bool> Handle(DeclineLeadRequest request, CancellationToken cancellationToken)
        {
            var entity = _repository.GetById(request.Id).Result;

            entity.Accepted = false;

            _repository.Update(entity);

            return Task.FromResult(true);
        }
    }
}
