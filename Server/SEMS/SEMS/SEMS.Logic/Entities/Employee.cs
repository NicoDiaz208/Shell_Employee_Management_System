using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEMS.Logic.Entities
{
    [Table("Employees", Schema = "App")]
    public class Employee: Applicant, IVersionable
    {
        [Required]
        public DateTime BeginDate { get; set; }
        [Required]
        public DateTime EndDate { get; set; }
        [Required, MaxLength(128)]
        public String ReasonForTermination { get; set; } = String.Empty;
    }
}
