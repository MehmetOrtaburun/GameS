using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class UserValidationManager : IUserValidationService
    {
        public bool Validation(Gamer gamer)
        {
            if (gamer.BirthYear == 1111 &&
                gamer.FirstName == "Ahmet" &&
                gamer.LastName == "Kamil" &&
                gamer.IdentityNumber == 11111

                )
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
