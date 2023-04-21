using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Recruiting.ApplicationCore.Contracts.Repositories;
using Recruiting.ApplicationCore.Contracts.Services;
using Recruiting.ApplicationCore.Models;
using Recruiting.Infrastructure.Services;

namespace MVCwithRecruiting.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JobRequirementController : ControllerBase
    {
        private readonly IJobRequirementService js;

        

        public JobRequirementController(IJobRequirementService jobRequirementService)
        {
            js = jobRequirementService;

        }
        [HttpGet]
        [Route("get all job requirements")]
        public async Task<IActionResult> GetAll()
        {
            var res = await js.GetAllJobRequirements();
            return Ok(res);
        }
        // GET: JobRequirementController
        /*
        public ActionResult Index()
        {
            return View();
        }

        // GET: JobRequirementController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: JobRequirementController/Create
        [HttpGet]
        public ActionResult Create()
        {

            return View();
        }

        //[HttpPost]
        //public async Task<IActionResult> Create(JobRequirementRequestModel model)
        //{
        //    //async service is needed
        //    if (!ModelState.IsValid)
        //    {
        //        var error = ModelState.Values.SelectMany(x => x.Errors).ToList();
        //        foreach (var item in error)
        //        {
        //            logger.LogError(item.ErrorMessage);
        //        }
        //    }
        //    return RedirectToAction("Submitted");
        //}
        [HttpPost]
        public async Task<IActionResult> Create(JobRequirementRequestModel model)
        {
            if (model != null)
            {
                await jobService.AddJobRequirementAsync(model);
                return View(model);
            }
            return View();
        }
        [HttpGet]
        public IActionResult Submitted()
        {
            return View();
        }
        

        // GET: JobRequirementController/Edit/5
        public ActionResult Update(int id)
        {
            return View();
        }

        // POST: JobRequirementController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: JobRequirementController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: JobRequirementController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
        */
       
    }
}
