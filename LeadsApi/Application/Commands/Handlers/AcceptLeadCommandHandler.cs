using LeadsApi.Domain.Interfaces;
using LeadsApi.Domain.Services;
using MediatR;

namespace LeadsApi.Application.Commands.Handlers
{
    public class AcceptLeadCommandHandler : IRequestHandler<AcceptLeadRequest, bool>
    {
        private readonly ILeadRepository _repository;
        private readonly IEmailService _emailService;

        public AcceptLeadCommandHandler(ILeadRepository leadRepository, IEmailService emailService)
        {
            _repository = leadRepository;
            _emailService = emailService;
        }
        public Task<bool> Handle(AcceptLeadRequest request, CancellationToken cancellationToken)
        {
            var entity = _repository.GetById(request.Id).Result;
            
            entity.Accepted = true;

            if (entity.Price > 500)
            {
                var discount = 0.9M;
                entity.Price *= discount;
            }

            _repository.Update(entity);

            var title = "Your lead was accepted!";
            var subject = $"Your lead was accepted with a final price of ${entity.Price}";

            _emailService.SendMail(title, subject, entity.Email);

            return Task.FromResult(true);
        }
    }
}
