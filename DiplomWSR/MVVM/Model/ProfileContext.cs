using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace DiplomWSR.MVVM.Model
{
    internal class ProfileContext : DbContext
    {
        public DbSet<Profile> Profiles { get; set; }

        public ProfileContext() : base("LogisticEntities") { }
    }
}
