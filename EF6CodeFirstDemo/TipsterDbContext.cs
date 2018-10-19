using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TipsterFootballApp;
using TipsterFootballApp.Model;

namespace TipsterData
{
    public class TipsterDbContext : DbContext
    {
        public TipsterDbContext() : base("TipsterAppDBConnectionString")
        {
            Database.SetInitializer<TipsterDbContext>(new CreateDatabaseIfNotExists<TipsterDbContext>());
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //Adds configurations for Student from separate class
            //modelBuilder.Configurations.Add(new StudentConfigurations());

            //modelBuilder.Entity<Teacher>()
            //    .ToTable("TeacherInfo");

            //modelBuilder.Entity<Teacher>()
            //    .MapToStoredProcedures();
        }

        public DbSet<Competition> Competitions { get; set; }
        public DbSet<Match> Matchs { get; set; }
        public DbSet<Score> Scores { get; set; }
        public DbSet<Season> Season { get; set; }
        public DbSet<Stading> Stadings { get; set; }
        public DbSet<Table> Tables { get; set; }
        public DbSet<Team> Teams { get; set; }
    }
}
