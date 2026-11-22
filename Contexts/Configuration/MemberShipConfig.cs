using GymSystem.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GymSystem.Contexts.Configuration
{
    public class MemberShipConfig : IEntityTypeConfiguration<MemberShip>
    {
        public void Configure(EntityTypeBuilder<MemberShip> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.CreatedAt)
                  .HasDefaultValueSql("GETDATE()");
        }
    }
}
