using GrnRentACar.DAL.Repositories.Abstract;

namespace GrnRentACar.Entities.Concrete
{
	public class User : BaseEntity<int>
	{
		public string UserName { get; set; }
		public virtual ICollection<Roles> Roles { get; set; }
		public string Password { get; set; }
		public string TcNo { get; set; }
		public string PhoneNumber { get; set; }
		public virtual ICollection<Rental> Rentals { get; set; }
	}
}
