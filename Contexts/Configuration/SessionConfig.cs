using GymSystem.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GymSystem.Contexts.Configuration
{
    public class SessionConfig : IEntityTypeConfiguration<Session>
    {
        public void Configure(EntityTypeBuilder<Session> builder)
        {
            builder.Property(x => x.CreatedAt)
                   .HasDefaultValueSql("GETDATE()");

            builder.HasOne(x=>x.Trainer)
                   .WithMany(x=>x.Sessions)
                   .HasForeignKey(x=>x.TrainerId)
                   .OnDelete(DeleteBehavior.Restrict);

            builder.ToTable(T =>
            {
                T.HasCheckConstraint("SessionCapacityCheck", "Capacity Between 1 and 25");
                T.HasCheckConstraint("SessionEndDateAfterStartDate", " EndDate > StartDate ");
            });
        }
    }
}
