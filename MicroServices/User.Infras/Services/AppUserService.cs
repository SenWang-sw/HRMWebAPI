using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using User.AppCore.Contract.Repo;
using User.AppCore.Contract.Services;
using User.AppCore.Models;

namespace User.Infras.Services
{
    public class AppUserService : IAppUserService
    {
        private readonly IAppUserRepo appUserRepo;

        public AppUserService(IAppUserRepo appUserRepo)
        {
            this.appUserRepo = appUserRepo;
        }

        public Task<SignInResult> LoginAsync(LoginModel loginModel)
        {
            return appUserRepo.LoginAsync(loginModel);
        }

        public Task<IdentityResult> SignUpAsync(SignUpModel model)
        {
            return appUserRepo.SignUpAsync(model);
        }
    }
}
