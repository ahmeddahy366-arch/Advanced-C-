using System;
using System.Collections.Generic;
using System.Text;

namespace Advanced_C_
{
   public static class Helper
    {
        public static T FindMax<T>(T a,T y)
        {
            if ((dynamic)a > y)
            {
                return a;
            }
            return y;
        }

    }
}
