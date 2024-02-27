using GrnRentACar.DAL.Repositories.Abstract;

namespace GrnRentACar.Entities.Concrete
{
	public class Customer : BaseEntity<int>
	{
		public string Name { get; set; }
		public string Surname { get; set; }
		public string TcNo { get; set; }
		public bool Gender { get; set; }
		public DateTime BirthDay { get; set; }
		public string Email { get; set; }

		public virtual ICollection<Rental> Rentals { get; set; }
	}
}