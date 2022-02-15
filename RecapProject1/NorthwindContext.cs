using RecapProject1.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecapProject1
{
    public class NorthwindContext:DbContext //context olabilmesi için DbContext i ekliyorum 
    {
        /* burada artık hangi nesnenin hangi veri tabanına bağlancağını belirtiriz*/
        public DbSet<Product> Products { get; set; } //elimde product var ve bu veri tabanında products a karşılık geliyor demek bu satır
        public DbSet<Category> Categories { get; set; }
    }
}
