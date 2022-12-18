using Data.Models;
using Data.DTO;
using Interview.Context;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics.Metrics;

namespace Interview.Repostory
{
    public class InterviewerRepo : IInterviewerRepo
    {
        protected readonly AppDbContext dbContext;

        public InterviewerRepo(AppDbContext dbContext)
        {
            this.dbContext = dbContext ?? throw new ArgumentNullException(nameof(dbContext));
        }

        public async Task<Interviewer> Add(Interviewer interviewer)
        {
            await dbContext.Interviewers.AddAsync(interviewer);
            await dbContext.SaveChangesAsync();
            return interviewer;
            
        }

        public async Task<Interviewer> Delete(int id)
        {
            var res = await dbContext.Interviewers.FirstOrDefaultAsync(x => x.Id == id);
            if (res != null)
            {
                dbContext.Interviewers.Remove(res);
                await dbContext.SaveChangesAsync();
                return res;
            }
            return null;
            
        }

        public async Task<IEnumerable<Interviewer>> GetAll()
        {
            return await dbContext.Interviewers.ToListAsync();

        }

        public async Task<Interviewer> GetId(int id)
        {
            return await dbContext.Interviewers.FirstAsync(c=>c.Id==id);
           
        }

        public async Task<Interviewer> Update(int id, Interviewer interviewer)
        {
            var inter = await dbContext.Interviewers.FindAsync(id);
            if (inter == null) 
                await dbContext.Interviewers.AddAsync(interviewer);
            else 
                dbContext.Entry(inter).CurrentValues.SetValues(interviewer);
            dbContext.SaveChanges();
            return interviewer;
            
        }
    }
}
