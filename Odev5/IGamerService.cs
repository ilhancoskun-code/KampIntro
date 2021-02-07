using System;
using System.Collections.Generic;
using System.Text;

namespace Odev5
{
    interface IGamerService
    {
        void Add(Gamer gamer)
        {
            Console.WriteLine("Kayıt oldu!");
        }
        void Update(Gamer gamer)
        {
            Console.WriteLine("Kayıt güncellendi!");
        }
        void Delete(Gamer gamer)
        {
            Console.WriteLine("Kayıt silindi");
        }
    }
}
