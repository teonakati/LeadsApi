using MediatR;

namespace LeadsApi.Application.Commands
{
    public class CreateLeadRequest : IRequest<CreateLeadResponse>
    {
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Suburb { get; set; }
        public string Category { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
    }
}
