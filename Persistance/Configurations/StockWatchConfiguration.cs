
namespace DashboardProject.Persistance.Configurations
{
	using Microsoft.EntityFrameworkCore.Metadata.Builders;
	using DashboardProject.Domain.Entities;
	using Microsoft.EntityFrameworkCore;

    public class StockWatchConfiguration
    {
	public void Configure(EntityTypeBuilder<StockWatch> builder) {
		builder.HasKey(x => x.Id);

		builder.Property(x => x.DisplayName)
			.IsRequired()
			.HasMaxLength(200);

		builder.Property(x => x.Symbol)
			.IsRequired()
			.HasMaxLength(5);
	}

    }
}
