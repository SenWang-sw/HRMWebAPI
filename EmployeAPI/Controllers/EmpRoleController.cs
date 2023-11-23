using Emp.AppCore.Contract.Service;
using Emp.AppCore.Entity;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EmployeAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmpRoleController : ControllerBase
    {
        private readonly IEmpRoleService s;

        public EmpRoleController(IEmpRoleService service)
        {
            s = service;
        }
        [HttpGet("get all")]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await s.GetAll());
        }
        [HttpGet("get by id")]
        public async Task<IActionResult> GetById(int id)
        {
            return Ok(await s.GetByIdAsync(id));
        }
        [HttpDelete("delete by id")]
        public async Task<IActionResult> DeleteById(int id)
        {
            return Ok(await s.DeleteAsync(id));
        }
        [HttpPost("Insert")]
        public async Task<IActionResult> Insert(EmpRole entity)
        {
            return Ok(await s.AddAsync(entity));
        }
        [HttpPost("Update")]
        public async Task<IActionResult> Update(EmpRole entity)
        {
            return Ok(await s.UpdateAsync(entity));
        }
    }
}
