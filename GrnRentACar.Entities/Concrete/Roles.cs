using GrnRentACar.DAL.Repositories.Abstract;

namespace GrnRentACar.Entities.Concrete
{
	public class Roles : BaseEntity<int>
	{
		public string RoleName { get; set; }
		public virtual ICollection<User> Users { get; set; }

	}
}