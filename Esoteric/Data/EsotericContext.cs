using Microsoft.EntityFrameworkCore;
using Esoteric.Models;

namespace Esoteric.Data
{
    public class EsotericContext : DbContext
    {
        public EsotericContext(DbContextOptions<EsotericContext> options) : base (options) { }

        public DbSet<Player> Players { get; set; }
    }
}
