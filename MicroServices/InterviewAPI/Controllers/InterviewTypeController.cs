using Interview.AppCore.Contract.Services;
using Interview.AppCore.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Recruiting.AppCore.Entities;

namespace InterviewAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InterviewTypeController : ControllerBase
    {
        private readonly IInterviewTypeServiceAsync it;

        public InterviewTypeController(IInterviewTypeServiceAsync interviewTypeServiceAsync)
        {
            it = interviewTypeServiceAsync;
        }
        [HttpGet]
        [Route("getall")]
        public async Task<IActionResult> GetAll() 
        {
            return Ok(await it.GetAll());
        }
        [HttpPost]
        [Route("insert")]
        public async Task<IActionResult> Insert(InterviewType interviewType)
        {
            return Ok(await it.AddInterviewTypeAsync(interviewType));
        }
        [HttpPost]
        [Route("update")]
        public async Task<IActionResult> Update(InterviewType interviewType)
        {
            return Ok(await it.UpdateInterviewTypeAsync(interviewType));
        }
        [HttpPost]
        [Route("delete")]
        public async Task<IActionResult> Delete(int id)
        {
            return Ok(await it.DeleteInterviewTypeAsync(id));
        }
        [HttpGet]
        [Route("GetById")]
        public async Task<IActionResult> GetById(int id)
        {
            return Ok(await it.GetInterviewTypeByIdAsync(id));
        }
    }
}
