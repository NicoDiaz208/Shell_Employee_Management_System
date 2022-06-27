using System.ComponentModel.DataAnnotations;

namespace SEMS.WebApi.Models
{
    public abstract partial class IdentityModel : Logic.IIdentifyable
    {
        /// <summary>
        /// ID of the entity (primary key)
        /// </summary>
        [Key]
        public int Id { get; set; }
    }
}
