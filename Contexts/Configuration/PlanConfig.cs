using GymSystem.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GymSystem.Contexts.Configuration
{
    public class PlanConfig : IEntityTypeConfiguration<Plan>
    {
        public void Configure(EntityTypeBuilder<Plan> builder)
        {
            builder.Property(x => x.CreatedAt)
                  .HasDefaultValueSql("GETDATE()");

            builder.ToTable(T =>
            {
                T.HasCheckConstraint("PlanDurationCheck", "DurationDays Between 1 and 365");
            });
        }
    }
}
