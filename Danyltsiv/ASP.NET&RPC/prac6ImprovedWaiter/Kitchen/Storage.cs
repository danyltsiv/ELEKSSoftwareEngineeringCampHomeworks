using System;
using System.Collections.Generic;
using System.Linq;
using WaiterServiceProto;

namespace Kitchen
{
    public class Storage
    {
        public productArr products = new productArr();
        public orderArr activeOrders = new orderArr();
        public orderArr closedOrders = new orderArr();
        
        public Storage()
        {
            Product product1 = new Product();
            product1.Id = 0;
            product1.Name = "Kartoplia";
            product1.Description = "Smachna";

            Product product2 = new Product();
            product2.Id = 1;
            product2.Name = "Piwo";
            product2.Description = "Hmilne";

            Product product3 = new Product();
            product3.Id = 2;
            product3.Name = "Sous";
            product3.Description = "Tartar";

            products.Values.Add(product1);
            products.Values.Add(product2);
            products.Values.Add(product3);
        }
    }
}
