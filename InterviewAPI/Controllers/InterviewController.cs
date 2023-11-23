using Interview.AppCore.Contract.Services;
using Interview.AppCore.Entities;
using Interview.AppCore.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net.Http;

namespace InterviewAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InterviewController : ControllerBase
    {
        private readonly IInterviewServiceAsync iww;
        private readonly ILogger logger;
        public InterviewController(IInterviewServiceAsync interviewServiceAsync)
        {
            iww = interviewServiceAsync;
        }
        [HttpGet("getall")]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await iww.GetAll());
        }
        [HttpPost("insert")]
        public async Task<IActionResult> Insert(Intervieww interviewType)
        {
            return Ok(await iww.AddInterviewAsync(interviewType));
        }
        [HttpPost]
        [Route("update")]
        public async Task<IActionResult> Update(Intervieww interviewType)
        {
            return Ok(await iww.UpdateInterviewAsync(interviewType));
        }
        [HttpDelete]
        [Route("delete")]
        public async Task<IActionResult> Delete(int id)
        {
            return Ok(await iww.DeleteInterviewAsync(id));
        }
        [HttpGet]
        [Route("GetById")]
        public async Task<IActionResult> GetById(int id)
        {
            return Ok(await iww.GetInterviewByIdAsync(id));
        }
        [HttpGet]
        [Route("getCandidate")]
        public async Task<IActionResult> GetCandidate()
        {
            string str = "http://host.docker.internal:40123/api/Candidate/getall";
            HttpClient client = new HttpClient();
            //client.BaseAddress = new Uri("http://localhost:40123/api/");
            var candidateResponse = await client.GetFromJsonAsync<IEnumerable<CandidateReponse>>(str);
            if (candidateResponse != null)
            {
                return Ok(candidateResponse);
            }
            return BadRequest();
        }
    }
}
