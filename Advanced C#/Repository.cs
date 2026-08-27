using System;
using System.Collections.Generic;
using System.Text;

namespace Advanced_C_
{
    internal class Repository<T> where T : IEntity
    {
        public void PrintId( T Item)
        {
            Console.WriteLine(Item.Id);

        }
    }
}
