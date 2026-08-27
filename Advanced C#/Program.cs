using Advanced_C_.question12;
using Advanced_C_.question14;
using Advanced_C_.question15;
using System.Data;
using System.Diagnostics.Metrics;
using System.Reflection.Metadata;
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
            #endregion question6
            // int xx = 50;
            // int yy = 60;
            //int NumberMax= Helper.FindMax<int>(xx, yy);
            // Console.WriteLine(NumberMax);
            // double p = 50.44;
            // double k = 60.44;
            // double numberMax = Helper.FindMax<double>(p, k);
            // Console.WriteLine(numberMax);

            #region question7
            //Calculator<int > calculator = new Calculator<int>();

            #endregion
            #region question8


            //Repository1<string> repository = new Repository1<string>();
            #endregion
            #region question9

            //Factory<Customer1> f1 = new Factory<Customer1>();
            //f1.CreateInstance();
            #endregion
            #region question10

            //Product product = new Product { Id = 10 , Name="ahmed"}; 
            //Repository<Product> p1=new Repository<Product>();
            //p1.PrintId(product);
            #endregion
            #region question11
            //Circle myCircle =new Circle();
            //Canvas<Circle> canvas1 = new Canvas<Circle>();  
            //canvas1.Render(myCircle);

            #endregion
            #region question12
            //DataManager<product> productt= new DataManager<product>();
            //productt.process();
            #endregion
            #region question14

            //SafeList<int> list = new SafeList<int>();
            //list.add(10);
            //list.add(20);
            //Console.WriteLine(list [9]);
            #endregion
            #region question15
            //IProducer<Dog> d1 = new DogProducer();
            //var n = d1.Get();
            //Console.WriteLine(n);
            //Console.WriteLine(n.Name);
            #endregion
            #region question18

            //counter<int> count1 = new counter<int>();
            //counter<int> count2 = new counter<int>();
            //counter<int> count3 = new counter<int>();
            //counter<int> count4 = new counter<int>();
            //counter<int> count5 = new counter<int>();
            //counter<int> count6 = new counter<int>();
            //counter<string> count11 = new counter<string>();
            //Console.WriteLine(counter<string>.count);

            //Console.WriteLine(counter<int>.count);
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
#region question7
//What is the 'struct' constraint? Write an example.
//The `struct` constraint specifies that the generic parameter `T` 
//accepts only value types(such as `int` and `double`) and does not accept reference types(such as `string` or `class`).
// Syntax: It is written as `where T : struct`.
#endregion
#region question8
//What is the 'class' constraint? Write an example.
//The class constraint specifies that the generic type parameter
//T must be a reference type (such as string, class, interface, or delegate). 

//Syntax: where T: class

#endregion
#region question9
//What is the 'new()' constraint? Write an example.
//The new() constraint specifies that a generic type parameter
//    (T) must have a public parameterless constructor
#endregion
#region question10
//What is the interface constraint? Write an example.
//The interface constraint specifies that the generic type parameter T must implement a specific interface

#endregion
#region question11
//What is the base class constraint? Write an example.
//The base class constraint specifies that the generic type parameter T
//    must inherit from a specific base class (or be that class itself).
#endregion
#region question13
//What does the 'default' keyword do in generics?
//The `default` keyword in Generics is used to obtain the default value for the generic type `T`
//    when you are unsure whether `T` is a value type or a reference type.
#endregion
#region question
//What is covariance? Explain the 'out' keyword.
//Covariance allows us to use a more derived type (Child) where a base type (Parent) is expected.
//we use the out keyword for covariance in generic interfaces and delegates, when the type is used only as an output
#endregion
#region question16
//Q16: What is contravariance? Explain the 'in' keyword.
//Contravariance allows us to use a generic type of a base class 
//    (Parent) where a derived class (Child) is expected.
//we use the in keyword for contravariance when the type is used as an input, such as a method parameter.
#endregion
#region question17

//What is the difference between covariance and
//contravariance?
//Covariance allows us to use a more derived type (Child) where a base type (Parent) is expected.
//we use the out keyword for covariance in generic interfaces and delegates, when the type is used only as an output
//Contravariance allows us to use a generic type of a base class
//    (Parent) where a derived class (Child) is expected.
//we use the in keyword for contravariance when the type is used as an input, such as a method parameter.
#endregion
