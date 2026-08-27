using System.Diagnostics.Metrics;
using System.Threading.Channels;

namespace Advanced_C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //    Container<int>c1= new Container<int>();
            //    c1.Add(1);
            //    c1.Add(2);
            //    c1.Add(3);
            //    int result = c1.Get();
            //    Console.WriteLine(result);

        }
    }
}
//Q1: What is a generic class? Why use generics?
//Code written once that allows you to specify the data type 
//    (such as numbers, text, or objects) 
//    later at the time of use, rather than fixing it during writing
//because 1. Type Safety:
//2.Code Reusability:
//3.Performance:
//4.Clean Code:
#region question3
//Q3: What are multiple type parameters? Write Pair<TKey,
//TValue>.
//The goal of generics is to enable a class, interface,
//    or function to accept multiple type placeholders simultaneously
//    (such as `<T1, T2>` or `<TKey, TValue>`).
#endregion
