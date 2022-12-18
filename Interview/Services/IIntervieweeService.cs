using Data.DTO;
using Data.Models;

namespace Interview
{
    public interface IIntervieweeService
    {
       
        
        Task<IntervieweeDTO> Insert(IntervieweeDTO  intervieweeDTO);

        Task<IEnumerable<Interviewee>> GetAll();

        Task<IntervieweeDTO> Update(int id, IntervieweeDTO  intervieweeDTO);
        
        Task<Interviewee> Delete(int id);

        Task<Interviewee> GetId(int id);

    }
}
