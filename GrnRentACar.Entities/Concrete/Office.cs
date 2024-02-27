using GrnRentACar.DAL.Repositories.Abstract;

namespace GrnRentACar.Entities.Concrete
{
	public class Office : BaseEntity<int>
	{
		public string Location { get; set; }
		public string Name { get; set; }
		public string OfficeAddress { get; set; }
		public string OfficeNumber { get; set; }



		public ICollection<Rental> Rentals { get; set; }

		public virtual ICollection<Employee> Employees { get; set; }
	}
}
