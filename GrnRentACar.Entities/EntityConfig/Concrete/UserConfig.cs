using GrnRentACar.Entities.Concrete;
using GrnRentACar.Entities.EntityConfig.Abstract;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GrnRentACar.Entities.EntityConfig.Concrete
{
	public class UserConfig : BaseConfig<User, int>
	{
		public override void Configure(EntityTypeBuilder<User> builder)
		{
			base.Configure(builder);
			builder.Property(p => p.TcNo).HasMaxLength(11);
		}
	}
}
