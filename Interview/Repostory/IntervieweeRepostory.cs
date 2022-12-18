using Data.Models;
using Interview.Context;
using Interview;
using Microsoft.EntityFrameworkCore;

namespace Interview
{
    public class IntervieweeRepostory : IIntervieweeRepostory
    {
        private readonly AppDbContext _db;

        public IntervieweeRepostory(AppDbContext db)
        {
            _db = db ?? throw new ArgumentNullException(nameof(db));
        }

        public async Task<Interviewee> Create(Interviewee interviewee)
        {
            await _db.Interviewees.AddAsync(interviewee);
            await _db.SaveChangesAsync();
            return interviewee;

        }
       

        public async Task<Interviewee> Delete(int id)
        {
            var res =  await _db.Interviewees.FirstOrDefaultAsync(x => x.Id == id);
            if (res != null)
            {
                _db.Interviewees.Remove(res);
                await _db.SaveChangesAsync();
                return res;
            }
            return null;
        }

        public async Task<IEnumerable<Interviewee>> GetAll()
        {
            return await _db.Interviewees.ToListAsync();
        }

        public async Task<Interviewee> Get(int id)
        {
            return await _db.Interviewees.FirstAsync(c => c.Id == id);  
        }

        public async Task<Interviewee> Update(int id, Interviewee interviewee)
        {
            var current = await _db.Interviewees.FindAsync(id);
            if (current == null)
            {
                await _db.Interviewees.AddAsync(interviewee);

            }
            else
            {
                _db.Entry(current).CurrentValues.SetValues(interviewee);
            }
             _db.SaveChangesAsync();
            return interviewee;
        }

       
    }
}
