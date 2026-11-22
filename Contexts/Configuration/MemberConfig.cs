using GymSystem.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GymSystem.Contexts.Configuration
{
    public class MemberConfig : GymUserConfigurations<Member>, IEntityTypeConfiguration<Member>
    {
        public new void Configure(EntityTypeBuilder<Member> builder)
        {
            builder.Property(x => x.CreatedAt)
                   .HasColumnName("JoinDate")
                   .HasDefaultValueSql("GETDATE()");

           base.Configure(builder);
        }
    }
}
