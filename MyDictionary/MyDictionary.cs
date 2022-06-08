using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionary
{
    class MyDictionary<K,V>
    {
        K[] Keys;
        V[] Values;

        public MyDictionary()
        {
            Keys = new K[0];
            Values = new V[0];
        }

        public void Add(K Key, V Value)
        {
            K[] TempKey = Keys;
            V[] TempVal = Values;

            Keys = new K[Keys.Length + 1];
            Values = new V[Values.Length + 1];

            for (int i = 0; i < TempKey.Length; i++)
            {
                Keys[i] = TempKey[i];
                Values[i] = TempVal[i];
            }
            Keys[Keys.Length - 1] = Key;
            Values[Values.Length - 1] = Value;
        }
        

    }
}
