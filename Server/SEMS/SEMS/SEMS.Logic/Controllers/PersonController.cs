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
            return base.InsertAsync(CheckEntity(entity));
        }

        public override Task<Person> UpdateAsync(Person entity)
        {
            return base.UpdateAsync(CheckEntity(entity));
        }

        private Person CheckEntity(Person entity)
        {
            if (entity.EndDate != null && entity.BeginDate == null)
            {
                throw new Exception("Das Ende des Arbeitsverhältnisses kann nicht ohne ein Anfang des Arbeitsverhältnisses existieren!");
            }

            if (entity.BeginDate != null && entity.EndDate != null)
            {
                if (entity.BeginDate > entity.EndDate) throw new Exception("Das Datum des End-Arbeitsverhältnisses ist früher als das Datum des Start-Arbeitsverhältnisses!");
            }

            var year = (entity.Birthday.Year > 1999 ? entity.Birthday.Year - 2000 : entity.Birthday.Year - 1900);
            entity.SSN = 
                entity.SSN +
                entity.Birthday.Day +                                                                                       //Day
                (entity.Birthday.Month < 10 ? "0" + entity.Birthday.Month : entity.Birthday.Month) +                        //Month
                (year < 10 ? "0" + year : year);                                                                            //Year

            return entity;
        }
    }
}
