using SEMS.Logic.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEMS.Logic.Controllers
{
    public class EmployeeController: GenericController<Employee>
    {
        public EmployeeController()
        {

        }

        public EmployeeController(ControllerObject other): base(other)
        {

        }
    }
}
