using Emp.AppCore.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emp.Infras.Data
{
    public class EmpDbContext:DbContext
    {
        public EmpDbContext(DbContextOptions<EmpDbContext> options) : base(options)
        {

        }
        public DbSet<Emplo> Emps { get; set; }
        public DbSet<EmpRole> Roles { get; set; }
        public DbSet<EmpCate> Cates { get; set; }
        public DbSet<EmpStatus> Statuss { get; set; }
    }
}
