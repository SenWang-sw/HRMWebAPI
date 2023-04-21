using HRMWebAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Routing;
using System.Collections.Generic;

namespace HRMWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmpController : ControllerBase
    {
        private readonly List<EmpMod> emps;
        private readonly ILogger<EmpController>logger;
        public EmpController(ILogger<EmpController>logger)
        {
            this.logger = logger;
            emps = new List<EmpMod>
            {
               new EmpMod
               {
                   Id = 1,
                   Name = "Sen",
                   Age = 26,
               },
               new EmpMod
               {
                   Id = 2,
                   Name = "wang",
                   Age = 25,
               }
           };
        }
        [HttpGet]
        [Route("test1")]
        public IActionResult GetWelcomeMess()
        {
            try
            {
                throw new IndexOutOfRangeException();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
            
            //return NotFound();
        }
        [HttpGet]
        [Route("test2")]
        public IActionResult GetEmp()
        {
            return Ok(emps);
            //return NotFound();
        }
        [HttpGet]
        [Route("test3/{id:min(1):max(20)}")]//route constraint
        public IActionResult GetById(int id)
        {
            var res = emps.Find(x => x.Id == id);
            if (res != null)
            {
                return Ok(res);
            }
            return NotFound("emp not found");
        }
        [HttpGet]
        [Route("test4")]//query string params -> search
        public IActionResult GetByName1(string name)
        {
            var res = emps.Find(x => x.Name == name);
            if (res != null)
            {
                return Ok(res);
            }
            return NotFound("emp not found");
        }
        [HttpGet]
        [Route("test5/{name}")]
        public IActionResult GetByName2(string name)
        {
            var res = emps.Find(x => x.Name == name);
            if (res != null)
            {
                return Ok(res);
            }
            return NotFound("emp not found");
        }

    }
}
