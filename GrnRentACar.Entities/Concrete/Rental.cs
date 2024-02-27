using GrnRentACar.DAL.Repositories.Abstract;

namespace GrnRentACar.Entities.Concrete
{
	public class Rental : BaseEntity<int>
	{
		public DateTime StartDate { get; set; }
		public DateTime EndDate { get; set; }

		public Office Office { get; set; }

		public int OfficeId { get; set; }

		public Vehicle Vehicle { get; set; }

		public int VehicleId { get; set; }

		public User User { get; set; }

		public int UserId { get; set; }
		public int InvoiceNumber { get; set; }
		public decimal TotalAmount { get; set; }
		public DateTime RentalDate { get; set; }
		public int CustomerId { get; set; }
		public virtual Customer Customer { get; set; }

	}
}
