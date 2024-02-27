using GrnRentACar.DAL.Repositories.Abstract;

namespace GrnRentACar.Entities.Concrete
{
	public class VehicleCategory : BaseEntity<int>
	{
		public string CategoryName { get; set; }
		public virtual ICollection<Vehicle> Vehicles { get; set; }
	}
}
