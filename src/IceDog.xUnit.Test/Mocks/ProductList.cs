using System;
using System.Collections.Generic;
using System.Text;

namespace IceDog.xUnit.Test.Mocks
{
    public class ProductList : List<Product>
    {
        public ProductList()
        {
            Product[] _products = {
            new Product {Name = "Melon", Category = "Fruits",Discontinued=false,ProductionDate=new DateTime(2000,5,10)},
            new Product {Name = "Pear", Category = "Fruits",Discontinued=false,ProductionDate=new DateTime(2001,5,10)},
            new Product {Name = "Grape", Category = "Fruits",Discontinued=false,ProductionDate=new DateTime(2001,5,10)},
            new Product {Name = "Milk", Category = "Beverages",Discontinued=true,ProductionDate=new DateTime(2002,5,10)},
            new Product {Name = "Coca Cola", Category = "Beverages",Discontinued=true,ProductionDate=new DateTime(2003,5,10)},
            new Product {Name = "Pepsi Cola", Category = "Beverages",Discontinued=true,ProductionDate=new DateTime(2004,5,10)}
            };
            this.AddRange(_products);
        }
    }
}
