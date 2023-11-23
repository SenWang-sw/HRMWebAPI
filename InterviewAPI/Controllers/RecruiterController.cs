using Interview.AppCore.Contract.Services;
using Interview.AppCore.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace InterviewAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RecruiterController : ControllerBase
    {
        private readonly IRecruiterServiceAsync rt;

        public RecruiterController(IRecruiterServiceAsync recruiterServiceAsync)
        {
            rt = recruiterServiceAsync;
        }
        [HttpGet]
        [Route("getall")]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await rt.GetAll());
        }
        [HttpPost]
        [Route("insert")]
        public async Task<IActionResult> Insert(Recruiter interviewType)
        {
            return Ok(await rt.AddRecruiterAsync(interviewType));
        }
        [HttpPost]
        [Route("update")]
        public async Task<IActionResult> Update(Recruiter interviewType)
        {
            return Ok(await rt.UpdateRecruiterAsync(interviewType));
        }
        [HttpPost]
        [Route("delete")]
        public async Task<IActionResult> Delete(int id)
        {
            return Ok(await rt.DeleteRecruiterAsync(id));
        }
        [HttpGet]
        [Route("GetById")]
        public async Task<IActionResult> GetById(int id)
        {
            return Ok(await rt.GetRecruiterByIdAsync(id));
        }
    }
}
