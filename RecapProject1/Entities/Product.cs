using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecapProject1.Entities
{
    public class Product
    {
        public int  ProductId{ get; set; }

        public int CategoryId { get; set; }// foreign keyler  primary keyden sonra yazılır. 
        
        public string ProductName { get; set; }

        public decimal UnitPrice { get; set; }

        public Int16 UnitsInStock { get; set; }// database de bu smallint olduğu için bende Int16 türünde yazdım çünkü smallint in değer Int16 dır

        public string QuantityPerUnit { get; set; }
    }
}
