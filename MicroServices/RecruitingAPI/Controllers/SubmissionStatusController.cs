using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Recruiting.AppCore.Contract.Services;
using Recruiting.AppCore.Entities;

namespace RecruitingAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SubmissionStatusController : ControllerBase
    {
        private readonly ISubmissionStatusServiceAsync ss;

        public SubmissionStatusController(ISubmissionStatusServiceAsync submissionServiceAsync)
        {
            ss = submissionServiceAsync;
        }
        [HttpGet]
        [Route("getall")]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await ss.GetAll());
        }
        [HttpPost]
        [Route("insert")]
        public async Task<IActionResult> Insert(SubmissionStatus submission)
        {
            return Ok(await ss.AddSubmissionStatusAsync(submission));
        }
        [HttpPost]
        [Route("update")]
        public async Task<IActionResult> Update(SubmissionStatus submission)
        {
            return Ok(await ss.UpdateSubmissionStatusAsync(submission));
        }
        [HttpPost]
        [Route("delete")]
        public async Task<IActionResult> Delete(int id)
        {
            return Ok(await ss.DeleteSubmissionStatusAsync(id));
        }
        [HttpGet]
        [Route("GetById")]
        public async Task<IActionResult> GetById(int id)
        {
            return Ok(await ss.GetSubmissionStatusByIdAsync(id));
        }
    }
}
