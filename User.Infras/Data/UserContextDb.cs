using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using User.AppCore.Models;

namespace User.Infras.Data
{
    public class UserContextDb:IdentityDbContext<ApplicationUser>
    {
        public UserContextDb(DbContextOptions<UserContextDb> options):base(options)
        {
            
        }
        
    }
}
