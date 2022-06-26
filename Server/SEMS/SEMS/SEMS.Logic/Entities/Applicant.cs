using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEMS.Logic.Entities
{
    [Table("Applicants", Schema = "App")]

    public class Applicant: Person, IVersionable
    {
        [Required]
        public DateTime ApplicationDate { get; set; }
        [Required, MaxLength(64)]
        public String Referal { get; set; } = String.Empty;
    }
}
