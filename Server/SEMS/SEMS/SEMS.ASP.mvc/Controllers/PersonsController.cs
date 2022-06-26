using Microsoft.AspNetCore.Mvc;

namespace SEMS.ASP.mvc.Controllers
{
    public class PersonsController : GenericController<Logic.Entities.Person, Models.PersonModel>
    {
        public PersonsController(Logic.Controllers.PersonController controller): base(controller)
        {

        }
    }
}
