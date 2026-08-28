using Advanced_C_.question19generic;
using System;
using System.Collections.Generic;
using System.Text;

namespace Advanced_C_.question19generic
{
    #region question19
    public class BaseRepository<T>
    {
        public T Data { get; set; }

    }
}

public class UserRepository: BaseRepository<string>
    {






}
/////////////////////////////////////////
public class CustomRepository<T>:BaseRepository<T>
{
    public void Dispaly()
    {
        Console.WriteLine(Data);
    }
}

    #endregion
