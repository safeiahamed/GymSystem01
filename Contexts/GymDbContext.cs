using GymSystem.Entities;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace GymSystem.Contexts
{
    public class GymDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;DataBase=GymSystem;Trusted_Connection=true;TrustServerCertificate=true");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }

        #region Dbsets
        public DbSet<Trainer> Trainers { get; set; }
        public DbSet<Member> Members { get; set; }
        public DbSet<Plan> Plans { get; set; }
        public DbSet<Session> Sessions { get; set; }
        public DbSet<MemberShip> MembersShip { get; set; }
        #endregion
    }
}
