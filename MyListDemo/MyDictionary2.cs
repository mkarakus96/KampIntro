using System;
using System.Collections.Generic;
using System.Text;

namespace MyListDemo
{
    class MyDictionary2<K, V>
    {
        K[] Keys;
        V[] Values;
        public MyDictionary2()
        {
            Keys = new K[0];
            Values = new V[0];
        }

        public void Add(K Key, V Value)
        {
            K[] tempKey = Keys;
            V[] tempValue = Values;

            Keys = new K[Keys.Length + 1];
            Values = new V[Values.Length + 1];

            for (int i = 0; i < tempKey.Length; i++)
            {
                Keys[i] = tempKey[i];
                Values[i] = tempValue[i];
            }

            Keys[Keys.Length - 1] = Key;
            Values[Values.Length - 1] = Value;

        }
    }
}
