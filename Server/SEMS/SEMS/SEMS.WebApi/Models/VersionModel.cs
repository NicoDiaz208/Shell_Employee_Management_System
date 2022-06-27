using System.ComponentModel.DataAnnotations;

namespace SEMS.WebApi.Models
{
    public abstract class VersionModel: IdentityModel, Logic.IVersionable
    {
        /// <summary>
        /// Row version of the entity.
        /// </summary>
        [Timestamp]
        public byte[] RowVersion { get; set; } = Array.Empty<byte>();
    }
}
