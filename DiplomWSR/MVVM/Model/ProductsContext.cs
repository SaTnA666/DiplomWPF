using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
namespace DiplomWSR.MVVM.Model
{
    internal class ProductsContext : DbContext
    {
        public ProductsContext() : base("LogisticEntities")
        {

        }
        public DbSet<Product> Products { get; set; }
        
    }
}
