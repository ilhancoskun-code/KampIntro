using System;
using System.Collections.Generic;
using System.Text;

namespace Odev5
{
      class GameManager : IGameService
    {
        public void Add(Games game)
        {
            Console.WriteLine("Oyun ekldeni : " + game.GameName);
        }

        public void Update(Games game)
        {
            Console.WriteLine("Oyun güncellendi : " + game.GameName + " Fiyat : " + game.GamePrice);
        }

        public void Delete(Games game)
        {
            Console.WriteLine("Oyun silindi :" + game.GameName);
        }

    }
}
