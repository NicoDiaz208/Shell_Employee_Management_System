using System.ComponentModel.DataAnnotations;

namespace SEMS.ASP.mvc.Models
{
    public class PersonModel:VersionModel
    {
        [Required, MaxLength(10), MinLength(10)]
        public String SSN { get; set; } = String.Empty;

        [Required, MaxLength(64)]
        public String FirstName { get; set; } = String.Empty;
        [Required, MaxLength(64)]
        public String LastName { get; set; } = String.Empty;

        [Required, Phone]
        public String TelNr { get; set; } = String.Empty;
        [Required, MaxLength(128)]
        public String Address { get; set; } = String.Empty;
        [Required]
        public DateTime Birthday { get; set; }
        [Required]
        public int Place { get; set; }
        [Required, MaxLength(256)]
        public String Note { get; set; } = String.Empty;

        [Required]
        public DateTime ApplicationDate { get; set; }
        [Required, MaxLength(64)]
        public String Referal { get; set; } = String.Empty;

        [Required]
        public DateTime? BeginDate { get; set; }
        [Required]
        public DateTime? EndDate { get; set; }
        [Required, MaxLength(128)]
        public String? ReasonForTermination { get; set; } = String.Empty;
    }
}
