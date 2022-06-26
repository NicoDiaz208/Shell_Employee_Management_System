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
        [Required, MaxLength(1), MinLength(1)]
        public String Sex { get; set; } = String.Empty;

        [Required, Phone]
        public String TelNr { get; set; } = String.Empty;
        [Required, MaxLength(128)]
        public String Address { get; set; } = String.Empty;
        [Required]
        public int Place { get; set; }
        [Required, DataType(DataType.Date)]
        public DateTime Birthday { get; set; }
        [Required, MaxLength(256)]
        public String Note { get; set; } = String.Empty;

        [Required, DataType(DataType.Date)]
        public DateTime ApplicationDate { get; set; }
        [Required, MaxLength(64)]
        public String Referal { get; set; } = String.Empty;

        [DataType(DataType.Date)]
        public DateTime? BeginDate { get; set; }
        [DataType(DataType.Date)]
        public DateTime? EndDate { get; set; }
        [MaxLength(128)]
        public String? ReasonForTermination { get; set; }
    }
}
