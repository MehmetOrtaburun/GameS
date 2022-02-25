using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    interface IGamerService
    {
        // operasyonlar için Gamer parametre olarak verilir.
        void Add(Gamer gamer);
        void Update(Gamer gamer);
        void Delete(Gamer gamer);


    }
}
