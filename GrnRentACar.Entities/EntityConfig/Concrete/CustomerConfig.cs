using GrnRentACar.Entities.Concrete;
using GrnRentACar.Entities.EntityConfig.Abstract;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GrnRentACar.Entities.EntityConfig.Concrete
{
	public class CustomerConfig : BaseConfig<Customer, int>
	{
		public override void Configure(EntityTypeBuilder<Customer> builder)
		{
			base.Configure(builder);
			builder.Property(p => p.TcNo).HasMaxLength(11);
		}
	}
}
