using GrnRentACar.Entities.Concrete;
using GrnRentACar.Entities.EntityConfig.Abstract;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GrnRentACar.Entities.EntityConfig.Concrete
{
	public class EmployeeConfig : BaseConfig<Employee, int>
	{
		public override void Configure(EntityTypeBuilder<Employee> builder)
		{
			base.Configure(builder);
			builder.Property(p => p.TcNo).HasMaxLength(11);
			builder.Property(p => p.FullName).HasMaxLength(50);

		}

	}
}
