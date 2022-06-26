using System.ComponentModel.DataAnnotations;

namespace SEMS.ASP.mvc.Models
{
    public class ApplicantModel: VersionModel
    {
        [Required]
        public DateTime ApplicationDate { get; set; }
        [Required, MaxLength(64)]
        public String Referal { get; set; } = String.Empty;
    }
}
