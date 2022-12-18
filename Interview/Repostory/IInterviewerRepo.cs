using Data.Models;
using Data.DTO;
using System.Diagnostics.Metrics;

namespace Interview.Repostory
{
    public interface IInterviewerRepo
    {
        Task<Interviewer> Add(Interviewer interviewer);

        Task<IEnumerable<Interviewer>> GetAll();
        
        Task<Interviewer> Update(int id, Interviewer interviewer);
        
        Task<Interviewer> Delete(int id);

        Task<Interviewer> GetId(int id);


        
        
    }
}
