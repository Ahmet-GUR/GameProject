using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject
{
    class ProductManeger : IProductService
    {
        public void Sell(Product product, Gamer gamer)
        {
            Console.WriteLine(product.ProductName+" adlı oyun "+ gamer.FirtsName + " " + gamer.LastName + " adlı oyuncuya satışı yapıldı");
        }
    }
}
