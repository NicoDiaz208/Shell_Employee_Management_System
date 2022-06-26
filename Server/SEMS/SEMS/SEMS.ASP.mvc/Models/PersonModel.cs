using System.ComponentModel.DataAnnotations;

namespace SEMS.ASP.mvc.Models
{
    public class PersonModel:VersionModel
    {
        [Required, MaxLength(4), MinLength(4)]
        [Display(Name = "SVN *")]

        public String SSN { get; set; } = String.Empty;

        [Required, MaxLength(64)]
        [Display(Name = "Vorname *")]
        public String FirstName { get; set; } = String.Empty;
        [Required, MaxLength(64)]
        [Display(Name = "Nachname *")]
        public String LastName { get; set; } = String.Empty;
        [Required, MaxLength(1), MinLength(1)]
        [Display(Name = "Geschlecht *")]
        public String Sex { get; set; } = String.Empty;

        [Required, Phone]
        [Display(Name = "Telefon Nr. *")]
        public String TelNr { get; set; } = String.Empty;
        [Required, MaxLength(128)]
        [Display(Name = "Adresse *")]
        public String Address { get; set; } = String.Empty;
        [Required]
        [Display(Name = "PLZ *")]
        public int Place { get; set; }
        [Required, DataType(DataType.Date)]
        [Display(Name = "Geburtstag *")]
        public DateTime Birthday { get; set; }
        [MaxLength(256)]
        [Display(Name = "Notiz")]
        public String? Note { get; set; }

        [Required, DataType(DataType.Date)]
        [Display(Name = "Bewerbungsdatum *")]
        public DateTime ApplicationDate { get; set; }
        [Required, MaxLength(64)]
        [Display(Name = "Verweisung *")]
        public String Referal { get; set; } = String.Empty;

        [DataType(DataType.Date)]
        [Display(Name = "Anfang des Arbeitsverhältnisses")]
        public DateTime? BeginDate { get; set; }
        [DataType(DataType.Date)]
        [Display(Name = "Ende des Arbeitsverhältnisses")]
        public DateTime? EndDate { get; set; }
        [MaxLength(128)]
        [Display(Name = "Grund der Kündigung")]
        public String? ReasonForTermination { get; set; }
    }
}
