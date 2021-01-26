using System;
using System.Collections.Generic;
using System.Text;

namespace Gun4Odev5
{
    class MyDictionary<Kd,Vd>
    {
        Kd[] keyArray;
        Vd[] valueArray;

        public MyDictionary()
        {
            keyArray = new Kd[0];
            valueArray=new Vd[0];
        }


        public void Add(Kd kd, Vd vd )
        {
            Kd[] tempKeyArray = keyArray;
            Vd[] tempValueArray = valueArray;
            keyArray = new Kd[keyArray.Length + 1];
            valueArray = new Vd[valueArray.Length + 1];


            for (int i = 0; i < tempKeyArray.Length; i++)
            {
                keyArray[i] = tempKeyArray[i];

            }

            for (int j = 0; j < tempValueArray.Length; j++)
            {
                valueArray[j] = tempValueArray[j];
            }


            keyArray[keyArray.Length - 1] = kd;
            valueArray[valueArray.Length - 1] = vd;


         }

        public Kd[] itemkey
        {
            get { return keyArray; }
        }
        public Vd[] itemvalue
        {
            get { return valueArray; }
        }
        public int Length
        {
            get { return keyArray.Length; }
        }
    }
}
