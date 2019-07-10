using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    class Contextt: DbContext
    {
        public Contextt() : base("name=CourseJs")
        {
        }

        public DbSet<User> Users { get; set; }
    }
}
