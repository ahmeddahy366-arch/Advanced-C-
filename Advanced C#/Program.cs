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

            #region question5
            //int x = 5;
            //int y = 6;
            //Swapper.swap<int>(ref   x, ref  y);
            //Console.WriteLine($"x=> {x} :y=> {y}");
            //string name1 = "ahmed";
            //string name2 = "ali";
            //Swapper.swap<string>(ref name1, ref name2);
            //Console.WriteLine($"name1> {name1} :name2> {name2}");
            #endregion

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
#region question4
//What is a generic method? Write Swap<T> method.
//A generic function (or general method) is a function defined by symbolic type arguments (such as <T>),
//    allowing it to handle different types using only one piece of code.This is better than rewriting the function multiple times (overloading) for each type, such as int, string, or double.
#endregion
