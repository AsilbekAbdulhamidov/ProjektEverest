using Data.DTO;
using Interview;
using Microsoft.AspNetCore.Mvc;

namespace Interview.Controllers
{
    [Route("[controller]")]
    [ApiController]
    [Produces("application/json")]
    public class IntervieweeController : Controller
    {
        private readonly IIntervieweeService service;

        public IntervieweeController(IIntervieweeService service)
        {
            this.service = service;
        }
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await service.GetAll());

        }
        [HttpPost]
        public async Task<IActionResult> Insert( IntervieweeDTO intervieweeDTO)
        {
            return Ok(await service.Insert(intervieweeDTO));
           
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            return Ok(await service.Delete(id));
          

        }
        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, IntervieweeDTO intervieweeDTO)
        {
            return Ok(await service.Update(id, intervieweeDTO));

        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetId(int id)
        {
            return Ok(await service.GetId(id));
            
        }

    }
}
