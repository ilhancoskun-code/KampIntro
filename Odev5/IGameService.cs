using System;
using System.Collections.Generic;
using System.Text;

namespace Odev5
{
    public interface IGameService
    {
        void Add(Games game)
        {
            Console.WriteLine("Oyun ekldeni : " + game.GameName);
        }

        void Update(Games game)
        {
            Console.WriteLine("Oyun güncellendi : " + game.GameName + " Fiyat : " + game.GamePrice);
        }

        void Delete(Games game)
        {
            Console.WriteLine("Oyun silindi :" + game.GameName);
        }




    }
}
