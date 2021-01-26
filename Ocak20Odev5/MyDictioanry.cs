using System;
using System.Collections.Generic;
using System.Text;

namespace Ocak20Odev5
{
    class MyDictionary<Kd, Vd>
    {
        Kd[] kArray;
        Vd[] vArray;

        public MyDictionary()
        {
            kArray = new Kd[0];
            vArray = new Vd[0];
        }


        public void Add(Kd kd, Vd vd)
        {
            Kd[] tempKeyArray = kArray;
            Vd[] tempValueArray = vArray;
            kArray = new Kd[kArray.Length + 1];
            vArray = new Vd[vArray.Length + 1];


            for (int i = 0; i < tempKeyArray.Length; i++)
            {
                kArray[i] = tempKeyArray[i];

            }

            for (int j = 0; j < tempValueArray.Length; j++)
            {
                vArray[j] = tempValueArray[j];
            }


            kArray[kArray.Length - 1] = kd;
            vArray[vArray.Length - 1] = vd;


        }

        public Kd[] key
        {
            get { return kArray; }
        }
        public Vd[] value
        {
            get { return vArray; }
        }
        public int Length
        {
            get { return kArray.Length; }
        }
    }
}
