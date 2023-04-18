using System;
using System.Collections;

namespace SerializableYugi
{
    internal class ArrayList<T>
    {
        public static implicit operator ArrayList<T>(ArrayList v)
        {
            throw new NotImplementedException();
        }
    }
}