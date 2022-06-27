namespace SEMS.WebApi.Models
{
    public class PersonModel : VersionModel
    {
        public String SSN { get; set; } = String.Empty;
        public String FirstName { get; set; } = String.Empty;
        public String LastName { get; set; } = String.Empty;
        public String Sex { get; set; } = String.Empty;
        public String TelNr { get; set; } = String.Empty;
        public String Address { get; set; } = String.Empty;
        public int Place { get; set; }
        public DateTime Birthday { get; set; }
        public String? Note { get; set; }
        public DateTime ApplicationDate { get; set; }
        public String Referal { get; set; } = String.Empty;
        public DateTime? BeginDate { get; set; }
        public DateTime? EndDate { get; set; }
        public String? ReasonForTermination { get; set; }
    }
}
