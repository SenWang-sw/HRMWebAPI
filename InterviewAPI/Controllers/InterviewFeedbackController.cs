using Interview.AppCore.Contract.Services;
using Interview.AppCore.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace InterviewAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InterviewFeedbackController : ControllerBase
    {
        private readonly IInterviewFeedbackServiceAsync it;

        public InterviewFeedbackController(IInterviewFeedbackServiceAsync interviewFeedbackServiceAsync)
        {
            it = interviewFeedbackServiceAsync;
        }
        [HttpGet]
        [Route("getall")]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await it.GetAll());
        }
        [HttpPost]
        [Route("insert")]
        public async Task<IActionResult> Insert(InterviewFeedback interviewType)
        {
            return Ok(await it.AddInterviewFeedbackAsync(interviewType));
        }
        [HttpPost]
        [Route("update")]
        public async Task<IActionResult> Update(InterviewFeedback interviewType)
        {
            return Ok(await it.UpdateInterviewFeedbackAsync(interviewType));
        }
        [HttpPost]
        [Route("delete")]
        public async Task<IActionResult> Delete(int id)
        {
            return Ok(await it.DeleteInterviewFeedbackAsync(id));
        }
        [HttpGet]
        [Route("GetById")]
        public async Task<IActionResult> GetById(int id)
        {
            return Ok(await it.GetInterviewFeedbackByIdAsync(id));
        }
    }
}
