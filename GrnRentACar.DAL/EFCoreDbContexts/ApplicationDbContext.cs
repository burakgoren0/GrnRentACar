using GrnRentACar.Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace GrnRentACar.DAL.EFCoreDbContexts
{
	public class ApplicationDbContext : DbContext
	{
		public DbSet<Office> Offices { get; set; }
		public DbSet<User> Users { get; set; }
		public DbSet<Vehicle> Vehicles { get; set; }
		public DbSet<Rental> Rentals { get; set; }
		public DbSet<Customer> Customers { get; set; }
		public DbSet<Employee> Employees { get; set; }
		public DbSet<VehicleCategory> VehicleCategories { get; set; }






		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer("Server=LENOVO\\MSSQLSERVER01;Database=GrnRentACar;Trusted_Connection=True; TrustServerCertificate=true ");
		}


	}
}
