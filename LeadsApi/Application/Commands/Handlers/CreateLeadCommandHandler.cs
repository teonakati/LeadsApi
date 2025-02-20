using LeadsApi.Domain.Interfaces;
using MediatR;

namespace LeadsApi.Application.Commands.Handlers
{
    public class CreateLeadCommandHandler : IRequestHandler<CreateLeadRequest, CreateLeadResponse>
    {
        private readonly ILeadRepository _repository;

        public CreateLeadCommandHandler(ILeadRepository leadRepository)
        {
            _repository = leadRepository;
        }

        Task<CreateLeadResponse> IRequestHandler<CreateLeadRequest, CreateLeadResponse>.Handle(CreateLeadRequest request, CancellationToken cancellationToken)
        {
            var entity = _repository.CreateLead(request).Result;

            return Task.FromResult(new CreateLeadResponse
            {
                Id = entity.Id,
                Category = request.Category,
                Created = entity.DateCreated,
                Description = request.Description,
                Email = request.Email,
                Name = request.Name,
                Phone = request.Phone,
                Price = request.Price,
                Suburb = request.Suburb
            });
        }
    }
}
