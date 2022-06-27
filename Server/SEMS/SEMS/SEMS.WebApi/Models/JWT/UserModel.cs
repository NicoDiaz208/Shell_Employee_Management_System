namespace SEMS.WebApi.Models.JWT
{
    public class UserModel : VersionModel
    {
        public string Username { get; set; } = String.Empty;
        public string Password { get; set; } = String.Empty;
    }
}
