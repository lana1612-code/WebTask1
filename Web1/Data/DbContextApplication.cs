using Microsoft.EntityFrameworkCore;
using Web1.Models;

namespace Web1.Data
{
	public class DbContextApplication :DbContext
	{
		public DbSet<Employee>employees { get; set; }
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			base.OnConfiguring(optionsBuilder);
			optionsBuilder.UseSqlServer("server=.;database=web1;trusted_connection=true;trustServerCertificate=true;");
		}
	}
}
