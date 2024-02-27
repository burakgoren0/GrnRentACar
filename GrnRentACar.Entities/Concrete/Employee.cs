using GrnRentACar.DAL.Repositories.Abstract;

namespace GrnRentACar.Entities.Concrete
{
	public class Employee : BaseEntity<int>
	{
		public string FullName { get; set; }
		public string GSM { get; set; }
		public string Email { get; set; }
		public string TcNo { get; set; }
		public string Adress { get; set; }

		public virtual ICollection<Office> Offices { get; set; }
	}
}
