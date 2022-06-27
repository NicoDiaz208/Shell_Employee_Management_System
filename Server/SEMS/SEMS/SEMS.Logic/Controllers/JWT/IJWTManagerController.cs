using SEMS.Logic.Entities.JWT;

namespace SEMS.Logic.Controllers.JWT
{
    public interface IJWTManagerController
    {
        Task<Tokens?> Authenticate(String username, String password);
    }
}
