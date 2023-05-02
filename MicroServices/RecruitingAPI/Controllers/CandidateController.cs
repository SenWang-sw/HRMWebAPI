using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Recruiting.AppCore.Contract.Services;
using Recruiting.AppCore.Entities;

namespace RecruitingAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(Roles ="Admin,User")]
    public class CandidateController : ControllerBase
    {
        private readonly ICandidateServiceAsync candidateService;

        public CandidateController(ICandidateServiceAsync candidateService)
        {
            this.candidateService = candidateService;
        }
        [HttpGet]
        [Route("getall")]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await candidateService.GetAll());
        }
        [HttpPost]
        [Route("insert")]
        public async Task<IActionResult> Insert(Candidate c)
        {
            return Ok(await candidateService.AddCandidateAsync(c));
        }
        [HttpPost]
        [Route("update")]
        public async Task<IActionResult> Update(Candidate c)
        {
            return Ok(await candidateService.UpdateCandidateAsync(c));
        }
        [HttpPost]
        [Route("delete")]
        public async Task<IActionResult> Delete(int id)
        {
            return Ok(await candidateService.DeleteCandidateAsync(id));
        }
        [HttpGet]
        [Route("GetById")]
        public async Task<IActionResult> GetById(int id)
        {
            return Ok(await candidateService.GetCandidateByIdAsync(id));
        }
    }
}
