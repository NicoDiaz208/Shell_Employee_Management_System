using Microsoft.AspNetCore.Authorization;

namespace SEMS.WebApi.Controllers
{
    [Authorize]
    public class PersonController : GenericController<Logic.Entities.Person, Models.PersonModel, Models.PersonModel>
    {
        public PersonController(Logic.Controllers.PersonController controller) : base(controller)
        {
        }
    }
}
