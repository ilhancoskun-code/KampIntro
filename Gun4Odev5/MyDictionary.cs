using System;
using System.Collections.Generic;
using System.Text;

namespace Gun4Odev5
{
    class MyDictionary<K,V>
    {

        K[] keys;
        V[] values;
        //constructor >> class oluşurken direk çalışan yapılar
        public MyDictionary()
        {
            keys = new K[0];
            values = new V[0];
            
        }

        public void Add(K key,V value)
        {
            K[] tempKeys = keys;
            V[] tempValues = values;
            
            keys = new K[keys.Length + 1];
            values = new V[values.Length + 1];


            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];

            }

            items[items.Length - 1] = item;
        }
    }
}
