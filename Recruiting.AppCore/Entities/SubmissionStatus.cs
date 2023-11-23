using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recruiting.AppCore.Entities
{
    public class SubmissionStatus
    {
        [Key]
        public int LookupCode { get; set; }

        [Required]
        [StringLength(512)]
        public string Description { get; set; }
    }
}
