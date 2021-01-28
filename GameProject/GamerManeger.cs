using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject
{
    class GamerManeger : IGamerService
    {
        private IUserValidationService _validationService;

        public GamerManeger(IUserValidationService validationService)
        {
            _validationService = validationService;
        }

        public void Add(Gamer gamer)
        {
            if (_validationService.Validate(gamer) == true)
            {
                Console.WriteLine(gamer.Id + " " + gamer.FirtsName + " " + gamer.LastName + " adında yeni oyuncu eklendi");
            }

            else
            {
                Console.WriteLine("Doğrulama başarısız oyuna kayıt olamadınız.");
            }
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine(gamer.Id + " " + gamer.FirtsName + " " + gamer.LastName + " adındaki oyuncu silindi");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine(gamer.Id + " " + gamer.FirtsName + " " + gamer.LastName + " adındaki oyuncu bilgileri güncellendi");
        }
    }
}
