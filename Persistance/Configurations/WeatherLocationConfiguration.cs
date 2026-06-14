namespace DashboardProject.Persistance.Configurations
{
	using DashboardProject.Domain.Entities;
	using Microsoft.EntityFrameworkCore;
	using Microsoft.EntityFrameworkCore.Metadata.Builders;
    public class WeatherLocationConfiguration:IEntityTypeConfiguration<WeatherLocation>
    {
	    public void Configure(EntityTypeBuilder<WeatherLocation> builder) {
		    builder.HasKey(x => x.Id);
		    builder.Property(x =>  x.Name)
			    .IsRequired()
			    .HasMaxLength(90);
		    builder.Property(x => x.CountryCode)
			    .IsRequired()
			    .HasMaxLength(10);
	    }

    }
}
