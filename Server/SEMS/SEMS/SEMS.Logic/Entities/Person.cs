using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEMS.Logic.Entities
{
    [Table("Persons", Schema = "App")]
    [Index(nameof(SSN), IsUnique = true)]
    public class Person: VersionEntity
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
