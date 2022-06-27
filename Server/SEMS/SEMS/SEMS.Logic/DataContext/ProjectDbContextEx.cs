using Microsoft.EntityFrameworkCore;
using SEMS.Logic.Entities;
using SEMS.Logic.Entities.JWT;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEMS.Logic.DataContext
{
    partial class ProjectDbContext
    {
        public DbSet<Person> PersonSet { get; set; }
        public DbSet<User> UserSet { get; set; }


        partial void GetDbSet<E>(ref DbSet<E>? dbSet, ref bool handled) where E : IdentityEntity
        {
            if(typeof(E) == typeof(Person))
            {
                handled = true;
                dbSet = PersonSet as DbSet<E>;
            }
            if (typeof(E) == typeof(User))
            {
                handled = true;
                dbSet = UserSet as DbSet<E>;
            }
        }
    }
}
