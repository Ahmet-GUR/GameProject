using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject
{
    class UserValidationManeger : IUserValidationService
    {
        public bool Validate(Gamer gamer)
        {
            if (gamer.NationalityNumber == "12345678910" && gamer.FirtsName == "Ahmet" && gamer.LastName == "GÜR" && gamer.YerOfBirth == new DateTime(2004,06,06))
            {
                return true;
            }

            else
            {
                return false;
            }
        }
    }
}
