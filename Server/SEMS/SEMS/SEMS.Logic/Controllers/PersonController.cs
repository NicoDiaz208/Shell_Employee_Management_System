using SEMS.Logic.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEMS.Logic.Controllers
{
    public class PersonController: GenericController<Person>
    {
        public PersonController(): base()
        {

        }

        public PersonController(ControllerObject other): base(other)
        {

        }

        public override Task<Person> InsertAsync(Person entity)
        {
            return base.InsertAsync(entity);
        }
    }
}
