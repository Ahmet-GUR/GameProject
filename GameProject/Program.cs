using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Gamer gamer = new Gamer { Id = 1, FirtsName = "Ahmet", LastName = "GÜR", YerOfBirth = new DateTime(2004, 06, 06), NationalityNumber = "12345678910" };

            GamerManeger gamerManeger = new GamerManeger(new UserValidationManeger());
            gamerManeger.Add(gamer);

            Line();

            Product product = new Product { Id = 1, ProductName = "GTA5", UnitPrice = 100 };

            IProductService productService = new ProductManeger();
            productService.Sell(product,gamer);

            Line();

            Campaign campaign = new Campaign { Id = 1, CampaignName = "Asd", CampaignValidityPeriod = new DateTime(2021, 01, 31) };

            ICampaignService campaignService = new CampaignManeger();
            campaignService.Add(campaign);
            

            Console.ReadLine();
        }

        private static void Line()
        {
            Console.WriteLine("-----------------------");
        }
    }
}
