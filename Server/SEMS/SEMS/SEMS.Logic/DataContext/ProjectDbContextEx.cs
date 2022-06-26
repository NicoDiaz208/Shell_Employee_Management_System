using Microsoft.EntityFrameworkCore;
using SEMS.Logic.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEMS.Logic.DataContext
{
    partial class ProjectDbContext
    {
        public DbSet<Employee> EmployeeSet { get; set; }
        public DbSet<Person> PersonSet { get; set; }
        public DbSet<Applicant> ApplicantSet { get; set; }


        partial void GetDbSet<E>(ref DbSet<E>? dbSet, ref bool handled) where E : IdentityEntity
        {
            if(typeof(E) == typeof(Employee))
            {
                handled = true;
                dbSet = EmployeeSet as DbSet<E>;
            }
            if(typeof(E) == typeof(Person))
            {
                handled = true;
                dbSet = PersonSet as DbSet<E>;
            }
            if(typeof(E) == typeof(Applicant))
            {
                handled = true;
                dbSet = ApplicantSet as DbSet<E>;
            }
        }
    }
}
