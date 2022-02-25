using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    interface IUserValidationService
    {
        // Gamer doğrulanacağı için parametre olarak verilmeli
        bool Validation(Gamer gamer);

    }
}
