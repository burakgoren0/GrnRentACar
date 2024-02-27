using GrnRentACar.DAL.Repositories.Abstract;

namespace GrnRentACar.Entities.Concrete
{
	public class Vehicle : BaseEntity<int>
	{
		public string Brand { get; set; }

		public int Year { get; set; }

		public string Color { get; set; }

		public string PlateNumber { get; set; }
		public int Mileage { get; set; }

		public FuelType FuelType { get; set; }
		public int EngineSize { get; set; }
		public GearType GearType { get; set; }

		public double Price { get; set; }

		public virtual ICollection<Rental> Rentals { get; set; }
		public int VehicleCategoryId { get; set; }
		public VehicleCategory VehicleCategory { get; set; }
	}
}
