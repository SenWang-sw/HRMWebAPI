using Interview.AppCore.Contract.Services;
using Interview.AppCore.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace InterviewAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InterviewerController : ControllerBase
    {
        private readonly IInterviewerServiceAsync ier;

        public InterviewerController(IInterviewerServiceAsync interviewerServiceAsync)
        {
            ier = interviewerServiceAsync;
        }
        [HttpGet]
        [Route("getall")]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await ier.GetAll());
        }
        [HttpPost]
        [Route("insert")]
        public async Task<IActionResult> Insert(Interviewer interviewType)
        {
            return Ok(await ier.AddInterviewerAsync(interviewType));
        }
        [HttpPost]
        [Route("update")]
        public async Task<IActionResult> Update(Interviewer interviewType)
        {
            return Ok(await ier.UpdateInterviewerAsync(interviewType));
        }
        [HttpPost]
        [Route("delete")]
        public async Task<IActionResult> Delete(int id)
        {
            return Ok(await ier.DeleteInterviewerAsync(id));
        }
        [HttpGet]
        [Route("GetById")]
        public async Task<IActionResult> GetById(int id)
        {
            return Ok(await ier.GetInterviewereByIdAsync(id));
        }
    }
}
