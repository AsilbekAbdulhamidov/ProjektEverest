using AutoMapper;
using Data.DTO;
using Data.Models;
using Interview.Controllers;
using Interview;

namespace Interview
{
    public class IntervieweeService : IIntervieweeService
    {
        private readonly IIntervieweeRepostory repo;
        private readonly ILogger<IntervieweeController> logger;
        private readonly IMapper mapper;

        public IntervieweeService(IMapper mapper, IIntervieweeRepostory repostory, ILogger<IntervieweeController> logger)
        {
            this.mapper = mapper;
            this.repo = repostory;
            this.logger = logger;
        }

        public async Task<Interviewee> Delete(int id)
        {
            var inter = await repo.Get(id);
            return (mapper.Map<Interviewee>(await repo.Delete(id)));
           
        }

        public async Task<IEnumerable<Interviewee>> GetAll()
        {
            return await repo.GetAll();
        }

        public async Task<Interviewee> GetId(int id)
        {
            return await repo.Get(id);
        }

        public async Task<IntervieweeDTO> Insert(IntervieweeDTO intervieweeDTO)
        {
            var inter = mapper.Map<Interviewee>(intervieweeDTO);
            return (mapper.Map<IntervieweeDTO>(await repo.Create(inter)));
           
        }

        public async Task<IntervieweeDTO> Update(int id, IntervieweeDTO intervieweeDTO)
        {

            Interviewee interviewee = mapper.Map<Interviewee>(intervieweeDTO);
            interviewee.Id = id;
            return (mapper.Map<IntervieweeDTO>(await repo.Update(id, interviewee)));
            
        }
    }
}
