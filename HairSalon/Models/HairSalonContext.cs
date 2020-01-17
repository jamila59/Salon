using Microsoft.EntityFrameworkCore;

namespace HairSalon.Models
{
  public class HairSalon : DbContext
  {
    public virtual DbSet<Client> Clients { get; set; }

    public HairSalon(DbContextOptions options) : base(options) { }
  }
}