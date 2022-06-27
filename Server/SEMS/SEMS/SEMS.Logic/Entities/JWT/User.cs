using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SEMS.Logic.Entities.JWT
{
    [Table("UserClient", Schema = "App")]
    [Index(nameof(Username), IsUnique = true)]
    public class User: VersionEntity
    {
        [Required, MaxLength(32), MinLength(8)]
        public String Username { get; set; } = String.Empty;
        [Required, MaxLength(32), MinLength(8)]
        public String Password { get; set; } = String.Empty;
    }
}
