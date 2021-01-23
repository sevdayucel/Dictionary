using System;
using System.Collections.Generic;
using System.Text;

namespace Dictionary
{
    public class MyDictionary <TKey,TValue>
    {
        TKey[] keys;
        TValue[] values;
        TKey[] tempKey= new TKey[0];
        TValue[] tempValue= new TValue[0];
        public MyDictionary()
        {
            keys = new TKey[0];
            values = new TValue[0];
        }
        public void Add(TKey _key, TValue _value)
        {
            tempKey = keys;
            keys = new TKey[keys.Length + 1];
            
            tempValue = values;
            values = new TValue[values.Length + 1];
            
            for (int i = 0; i < tempKey.Length; i++)
            {
                keys[i] = tempKey[i];
                values[i] = tempValue[i];
            }
            keys[keys.Length - 1] =_key;
            values[values.Length - 1] = _value;

        }
        public void  Al()
        {
            for (int i = 0; i < keys.Length; i++)
            {
                Console.WriteLine(" Anahtar: {0} Değer: {1} ", keys[i], values[i]);
            }
        }
    }
}
