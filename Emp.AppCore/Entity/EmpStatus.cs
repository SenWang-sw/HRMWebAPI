using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emp.AppCore.Entity
{
    public class EmpStatus
    {
        [Key]
        public int Id{ get; set; }

        [MaxLength(512)]
        public string Description { get; set; }

        [MaxLength(16)]
        public string ABBR { get; set; }
    }
}
