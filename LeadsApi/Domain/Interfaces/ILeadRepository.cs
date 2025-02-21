using LeadsApi.Application.Commands;
using LeadsApi.Application.Queries;
using LeadsApi.Domain.Entities;

namespace LeadsApi.Domain.Interfaces
{
    public interface ILeadRepository
    {
        Task<List<LeadInvitedResponse>> GetInvitedLeads();
        Task<List<LeadAcceptedResponse>> GetAcceptedLeads();
        Task<Lead> CreateLead(CreateLeadRequest lead);
        Task<Lead> GetById(int id);
        Task Update(Lead lead);
    }
}
