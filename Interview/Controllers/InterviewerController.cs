using Data.DTO;
using Data.Models;
using Interview.Repostory;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Interview.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Produces("application/json")]
    public class InterviewerController : ControllerBase
    {
            protected readonly IInterviewerServices services;

            public InterviewerController(IInterviewerServices services)
            {
            this.services = services;
            }

            [HttpPost]
            [Route("Insert")]

            public async Task<IActionResult> Insert( AddInterviewerDTO addInterviewerDTO)
            {
                return Ok(await services.Insert(addInterviewerDTO));
            }

            [HttpGet]
            public async Task<IActionResult> GetAll()
            {
                return Ok(await services.GetAll());
            }

            [HttpPut("{id}")]

            public async Task<IActionResult> Update(int id, AddInterviewerDTO addInterviewerDTO)
            {
                return Ok(await services.Update(id, addInterviewerDTO));
            }

            [HttpDelete("{id}")]

            public async Task<IActionResult> Delete(int id)
            {
                return Ok(await services.Delete(id));
            }

            [HttpGet("{id}")]
            public async Task<IActionResult> GetId(int id)
            {
                return Ok(await services.GetId(id));
            }
    }
}


