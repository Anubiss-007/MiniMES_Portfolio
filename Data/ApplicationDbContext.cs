using Microsoft.EntityFrameworkCore;
using MiniMES_Portfolio.Models;

namespace MiniMES_Portfolio.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<ProductionData> ProductionDatas { get; set; }
        public DbSet<MachineStatus> MachineStatuses { get; set; }
    }
}