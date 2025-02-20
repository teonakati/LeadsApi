using LeadsApi.Application.Commands;
using LeadsApi.Application.Queries;
using LeadsApi.Domain.Entities;
using LeadsApi.Domain.Interfaces;
using LeadsApi.Infraestructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace LeadsApi.Infraestructure.Repository
{
    public class LeadRepository : ILeadRepository
    {
        private readonly LeadContext _context;

        public LeadRepository(LeadContext context)
        {
            _context = context;
        }
        public Task<Lead> CreateLead(CreateLeadRequest lead)
        {
            var entity = new Lead(
                lead.Name,
                lead.Phone,
                lead.Email,
                DateTime.Now,
                lead.Suburb,
                lead.Category,
                lead.Description,
                lead.Price,
                accepted: null
                );

            _context.Add(entity);
            _context.SaveChanges();

            return Task.FromResult(entity);
        }

        public Task Accept(int id)
        {
            var entity = _context.Set<Lead>().Find(id);

            if (entity is null) throw new Exception("Lead not found");


            entity.Accepted = true;
            _context.SaveChanges();

            return Task.CompletedTask;
        }

        public Task<List<LeadAcceptedResponse>> GetAcceptedLeads()
        {
            var result = _context.Set<Lead>()
                .AsNoTracking()
                .Where(x => x.Accepted == true)
                .Select(x => new LeadAcceptedResponse
                {
                    Id = x.Id,
                    Name = x.Name,
                    Category = x.Category,
                    Created = x.DateCreated,
                    Description = x.Description,
                    Email = x.Email,
                    Phone = x.Phone,
                    Price = x.Price,
                    Suburb = x.Suburb,
                })
                .ToList();

            return Task.FromResult(result);
        }

        public Task<List<LeadInvitedResponse>> GetInvitedLeads()
        {
            var result = _context.Set<Lead>()
                            .AsNoTracking()
                            .Where(x => x.Accepted == null)
                            .Select(x => new LeadInvitedResponse
                            {
                                Id = x.Id,
                                Name = x.Name,
                                Category = x.Category,
                                Created = x.DateCreated,
                                Description = x.Description,
                                Price = x.Price,
                                Suburb = x.Suburb,
                            })
                            .ToList();

            return Task.FromResult(result);
        }
    }
}
