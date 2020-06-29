using Microsoft.EntityFrameworkCore;
using MySportTeam.Models;

namespace MySportTeam.Data
{
    public class MySportTeamContext : DbContext
    {
        public MySportTeamContext (DbContextOptions<MySportTeamContext> options)
            : base(options)
        {
        }

        public DbSet<Athlete> Athlete { get; set; }
    }
}