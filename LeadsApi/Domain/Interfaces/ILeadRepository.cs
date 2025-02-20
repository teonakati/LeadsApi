using LeadsApi.Application.Commands;
using LeadsApi.Application.Queries;
using LeadsApi.Domain.Entities;

namespace LeadsApi.Domain.Interfaces
{
    public interface ILeadRepository
    {
        Task<List<LeadInvitedResponse>> GetInvitedLeads();
        Task<List<LeadAcceptedResponse>> GetAcceptedLeads();
        Task Accept(int id);
        Task<Lead> CreateLead(CreateLeadRequest lead);
    }
}
