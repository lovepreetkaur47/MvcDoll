using Microsoft.EntityFrameworkCore;
using MvcDoll.Models;


namespace MvcDoll.Data
{
    public class MvcDollContext : DbContext
    {
        public MvcDollContext(DbContextOptions<MvcDollContext> options)
            : base(options)
    {
    }

    public DbSet<Doll> Doll { get; set; }
}
}
