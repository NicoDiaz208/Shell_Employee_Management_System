using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SEMS.Logic.Controllers.JWT;
using SEMS.Logic.Entities.JWT;
using SEMS.WebApi.Models.JWT;

namespace SEMS.WebApi.Controllers
{

	[Authorize]
	[Route("api/[controller]")]
	[ApiController]
	public class UsersController : GenericController<Logic.Entities.JWT.User, Models.JWT.UserModel, Models.JWT.UserModel>
	{

		public UsersController(Logic.Controllers.JWT.UserController controller) : base(controller)
        {
        }

		[AllowAnonymous]
		[HttpPost]
		[Route("authenticate")]
		public async Task<IActionResult> Authenticate(String username, String password)
		{
			var token = await ((UserController)Controller).Authenticate(username, password);

			if (token == null)
			{
				return Unauthorized();
			}

			return Ok(token);
		}

		[AllowAnonymous]
		[HttpPost]
		[Route("Registrate")]
		public async Task<IActionResult> Registrate([FromBody]UserModel userdata)
        {
			var usr = new User();
			usr.Username = userdata.Username;
			usr.Password = userdata.Password;

			var i = await Controller.InsertAsync(usr);
			await Controller.SaveChangesAsync();

			return Ok(i);
        }
	}
}

