using AutoMapper;
using Data.DTO;
using Data.Models;
using Interview.Controllers;
using System.Diagnostics.Metrics;

namespace Interview.Repostory
{
    public class InterviewerService : IInterviewerServices
    {
        protected readonly IInterviewerRepo repo;
        protected readonly ILogger<InterviewerController> logger;
        protected readonly IMapper mapper;

        public InterviewerService(IInterviewerRepo repo, ILogger<InterviewerController> logger, IMapper mapper)
        {
            this.repo = repo;
            this.logger = logger;
            this.mapper = mapper;
        }

        public async Task<Interviewer> Delete(int id)
        {
            var inter = await repo.GetId(id);
            return (mapper.Map<Interviewer>(await repo.Delete(id)));
        }

        public async Task<IEnumerable<Interviewer>> GetAll()
        {
            return await repo.GetAll();
            
        }

        public async Task<Interviewer> GetId(int id)
        {
            return await repo.GetId(id);
           
        }

        public async Task<AddInterviewerDTO> Insert(AddInterviewerDTO addInterviewerDTO)
        {
           var inter = mapper.Map<Interviewer>(addInterviewerDTO);
           return (mapper.Map<AddInterviewerDTO>(await repo.Add(inter)));

        }

       

        public async Task<AddInterviewerDTO> Update(int id, AddInterviewerDTO addInterviewerDTO)
        {
            Interviewer interviewer = mapper.Map<Interviewer>(addInterviewerDTO);
            interviewer.Id = id;
            return (mapper.Map<AddInterviewerDTO>(await repo.Update(id, interviewer)));
        }

        
    }
}
