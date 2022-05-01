using backend.Models;
using Microsoft.EntityFrameworkCore;

namespace backend.Data
{
    public class JobsContext : DbContext
    {

        public JobsContext(DbContextOptions<JobsContext> options) : base(options)
        {

        }

        public virtual DbSet<Job> Jobs { get; set; }

        public virtual DbSet<JobTitle> JobsTitles { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Job>().HasKey(j => j.JobId).HasName("TestJobs");
            modelBuilder.Entity<JobTitle>().HasKey(j => j.JobTitleId).HasName("PK_Test_JobTitles");
            OneToManyConfiguration(modelBuilder);
        }

        private void OneToManyConfiguration(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<JobTitle>().HasMany(j => j.Jobs).WithOne(j => j.JobTitle).HasForeignKey(j => j.JobTitleId);
        }

    }
}
