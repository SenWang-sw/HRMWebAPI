using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Recruiting.AppCore.Contract.Services;
using Recruiting.AppCore.Entities;
using Recruiting.AppCore.Models;
using System.Threading.Tasks.Dataflow;

namespace RecruitingAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JobRequirementController : ControllerBase
    {
        private readonly IJobrequirementServiceAsync jr;

        public JobRequirementController(IJobrequirementServiceAsync jobrequirementServiceAsync)
        {
            jr = jobrequirementServiceAsync;
        }
        [HttpGet]
        [Route("getall")]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await jr.GetAll());
        }
        [HttpPost]
        [Route("insert")]
        public async Task<IActionResult> Insert(JobRequirementRequestModel j)
        {
            return Ok(await jr.AddJobRequirementAsync(j));
        }
        [HttpPost]
        [Route("update")]
        public async Task<IActionResult> Update(JobRequirement j)
        {
            return Ok(await jr.UpdateJobRequirementAsync(j));
        }
        [HttpPost]
        [Route("delete")]
        public async Task<IActionResult> Delete(int id)
        {
            return Ok(await jr.DeleteJobRequirementAsync(id));
        }
        [HttpGet]
        [Route("GetById")]
        public async Task<IActionResult> GetById(int id)
        {
            return Ok(await jr.GetJobRequirementByIdAsync(id));
        }
    }
}
