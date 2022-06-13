using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssigmentODBC
{
    public class Product
    {
        public int id { get; set; }
        public string proName { get; set; }
        public string proDesc { get; set; }
        public int Price { get; set; }

        public Product(int id, string proName, string proDesc, int price)
        {
            this.id = id;
            this.proName = proName;
            this.proDesc = proDesc;
            this.Price = price;
        }

        public override string ToString()
        {
            return String.Format("Product { id: {0} Name: {1} Description: {2} Price: {3} ", id, proName, proDesc, Price);
        }
    }
}

