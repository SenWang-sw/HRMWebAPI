using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using User.AppCore.Models;

namespace User.AppCore.Contract.Repo
{
    public interface IAppUserRepo
    {
        Task<IdentityResult> SignUpAsync(SignUpModel model);
        Task<SignInResult> LoginAsync(LoginModel loginModel);
    }
}
