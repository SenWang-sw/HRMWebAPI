using JWTAuthManager;
using JWTAuthManager.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using User.AppCore.Contract.Services;
using User.AppCore.Models;
using User.Infras.Repo;

namespace UserAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ApplicationUserController : ControllerBase
    {
        private readonly IAppUserService appUserService;
        private readonly JwtTokenHandler jwtTokenHandler;

        public ApplicationUserController(IAppUserService appUserService, JwtTokenHandler jwtTokenHandler)
        {
            this.appUserService = appUserService;
            this.jwtTokenHandler = jwtTokenHandler;
        }
        [HttpPost("SignUp")]
        public async Task<IActionResult> SignUp(SignUpModel signUp)
        {
           var res = await appUserService.SignUpAsync(signUp);
            if (res.Succeeded)
            {
                return Ok("User Created Successfully"); 
            }
            return BadRequest("User Created Failed");
        }
        [HttpPost("LoginForAdmin")]
        public async Task<IActionResult> LoginForAdmin(LoginModel model)
        {
            var result = await appUserService.LoginAsync(model);
            if (result.Succeeded)
            {
                AuthenRequest request = new AuthenRequest()
                {
                    UserName = model.UserName,
                    Password = model.Password,
                };
                var response = jwtTokenHandler.GenerateToken(request, "Admin");
                return Ok(response);
            }                
                return Unauthorized();
            
        }
        [HttpPost("LoginForUser")]
        public async Task<IActionResult> LoginForUser(LoginModel model)
        {
            var result = await appUserService.LoginAsync(model);
            if (result.Succeeded)
            {
                AuthenRequest request = new AuthenRequest()
                {
                    UserName = model.UserName,
                    Password = model.Password,
                };
                var response = jwtTokenHandler.GenerateToken(request, "User");
                return Ok(response);
            }
            return Unauthorized();

        }

    }
}
