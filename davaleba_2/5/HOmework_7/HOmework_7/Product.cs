using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HOmework_7
{
    public class Product
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Code { get; set; }
        public byte CategotyID { get; set; }
        public byte Quantity { get; set; }
        public string Measuring { get; set; }
        public DateTime? ExpirationDate { get; set; }
        public string Valute { get; set; }

    }
    public class ProductCategory
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
