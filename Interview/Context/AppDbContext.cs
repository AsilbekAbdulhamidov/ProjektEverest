using Data.Models;
using Microsoft.EntityFrameworkCore;

namespace Interview.Context
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : 
            base(options)
        {
        }


        public DbSet<Category> Categories { get; set; }    
        public DbSet<Interviewee> Interviewees { get; set; }
        public DbSet<Interviewer> Interviewers { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Interviewee>().
                HasOne(e => e.Category)
                .WithOne(e => e.Interviewee)
                .HasForeignKey<Category>(p => p.InterviewerId);

            builder.Entity<Interviewer>().
                HasOne(e => e.Category)
                .WithOne(e => e.Interviewer)
                .HasForeignKey<Category>(p => p.InterviewerId);

        }

       
    }
}
