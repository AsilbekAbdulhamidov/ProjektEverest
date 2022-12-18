using Data.Models;
using Microsoft.EntityFrameworkCore.Query.Internal;

namespace Interview
{
    public interface IIntervieweeRepostory
    {
        Task<IEnumerable<Interviewee>> GetAll();
        
        Task<Interviewee> Get(int id);
        
        Task<Interviewee> Create (Interviewee interviewee);
        
        Task<Interviewee> Update (int id, Interviewee interviewee);
        
        Task<Interviewee> Delete (int id);


    }
}
