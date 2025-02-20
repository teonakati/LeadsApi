using LeadsApi.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace LeadsApi.Infraestructure.Persistence
{
    public class LeadContext : DbContext
    {
        public LeadContext(DbContextOptions<LeadContext> options) : base(options) { }

        public DbSet<Lead> Leads { get; set; }

    }
}

