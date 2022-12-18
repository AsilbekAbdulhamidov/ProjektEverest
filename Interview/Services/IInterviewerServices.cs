using Data.DTO;
using Data.Models;
using System.Diagnostics.Metrics;

namespace Interview.Repostory
{
    public interface IInterviewerServices
    {
        Task<AddInterviewerDTO> Insert(AddInterviewerDTO addInterviewerDTO);

        Task<IEnumerable<Interviewer>> GetAll();

        Task<AddInterviewerDTO> Update(int id, AddInterviewerDTO addInterviewerDTO);
        Task<Interviewer> Delete(int id);

        Task<Interviewer> GetId(int id);
        

    }
}
