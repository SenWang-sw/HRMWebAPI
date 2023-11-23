using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emp.AppCore.Entity
{
    public class Emplo
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(128)]
        public string FirstName { get; set; }

        [Required]
        [MaxLength(128)]
        public string LastName { get; set; }

        [MaxLength(128)]
        public string MiddleName { get; set; }

        [Required]
        [MaxLength(9)]
        public string SSN { get; set; }

        public DateTime? HireDate { get; set; }

        public DateTime? EndDate { get; set; }

        [ForeignKey("EmployeeCategory")]
        public int EmployeeCategoryCode { get; set; }

        [ForeignKey("EmployeeStatus")]
        public int EmployeeStatusCode { get; set; }


        [MaxLength]
        public string Address { get; set; }

        [Required]
        [MaxLength]
        public string Email { get; set; }

        [ForeignKey("EmployeeRole")]
        public int EmployeeRoleCode { get; set; }

    }
}
