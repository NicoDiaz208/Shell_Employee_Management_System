using System.ComponentModel.DataAnnotations;

namespace SEMS.ASP.mvc.Models
{
    public class EmployeeModel: VersionModel
    {
        [Required]
        public DateTime BeginDate { get; set; }
        [Required]
        public DateTime EndDate { get; set; }
        [Required, MaxLength(128)]
        public String ReasonForTermination { get; set; } = String.Empty;
    }
}
