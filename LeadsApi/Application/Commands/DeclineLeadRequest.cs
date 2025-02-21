using MediatR;

namespace LeadsApi.Application.Commands
{
    public class DeclineLeadRequest : IRequest<bool>
    {
        public DeclineLeadRequest(int id)
        {
            Id = id;
        }

        public int Id { get; set; }

        
    }
}
