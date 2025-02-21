using MediatR;

namespace LeadsApi.Application.Commands
{
    public class AcceptLeadRequest : IRequest<bool>
    {
        public AcceptLeadRequest(int id)
        {
            Id = id;
        }

        public int Id { get; set; }

        
    }
}
