using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using User.AppCore.Contract.Repo;
using User.AppCore.Models;
using User.Infras.Data;

namespace User.Infras.Repo
{
    public class AppUserRepo:IAppUserRepo
    {
        private readonly UserManager<ApplicationUser> userManager;
        private readonly SignInManager<ApplicationUser> signInManager;

        public AppUserRepo(UserManager<ApplicationUser> userManager, 
            SignInManager<ApplicationUser> signInManager)
        {
            this.userManager = userManager;
            this.signInManager = signInManager;
        }
        public async Task<IdentityResult> SignUpAsync(SignUpModel model)
        {
            ApplicationUser user = new ApplicationUser()
            {
                FirstName = model.FirstName,
                LastName = model.LastName,
                Email = model.Email,
                UserName = model.Email,

            };
            return await userManager.CreateAsync(user,model.Password);

        }
        public async Task<SignInResult> LoginAsync(LoginModel model)
        {
           var res = await signInManager.
                PasswordSignInAsync(model.UserName, model.Password,false,false);
            return res;
        }
    }
}
