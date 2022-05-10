using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace DiplomWSR.MVVM.Model
{
   public class DbContextStatistict : DbContext
    {

        public DbContextStatistict(): base("LogisticEntities")
        {

        }
        public DbSet<Statistics> Statistics { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
