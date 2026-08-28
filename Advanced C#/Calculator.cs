using System;
using System.Collections.Generic;
using System.Text;

namespace Advanced_C_
{
    internal class Calculator<T> where T:struct
    {
        public T Value { get; set; }

    }
}
