using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Recruiting.AppCore.Contract.Services;
using Recruiting.AppCore.Entities;
using Recruiting.AppCore.Models;

namespace RecruitingAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SubmissionController : ControllerBase
    {
        private readonly ISubmissionServiceAsync ss;

        public SubmissionController(ISubmissionServiceAsync submissionServiceAsync)
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
        public async Task<IActionResult> Insert(Submission submission)
        {
            return Ok(await ss.AddSubmissionAsync(submission));
        }
        [HttpPost]
        [Route("update")]
        public async Task<IActionResult> Update(Submission submission)
        {
            return Ok(await ss.UpdateSubmissionAsync(submission));
        }
        [HttpPost]
        [Route("delete")]
        public async Task<IActionResult> Delete(int id)
        {
            return Ok(await ss.DeleteSubmissionAsync(id));
        }
        [HttpGet]
        [Route("GetById")]
        public async Task<IActionResult> GetById(int id)
        {
            return Ok(await ss.GetSubmissionByIdAsync(id));
        }
    }
}
