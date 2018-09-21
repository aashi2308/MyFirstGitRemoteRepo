using System;

namespace AnonymousMethod
{
   
    //class Program
    //{
    //    public delegate void PrintValues(int values);
    //    static void Main(string[] args)
    //    {
    //        PrintValues print = delegate (int values)
    //         {
    //             Console.WriteLine("{0} Hello, I am an Anonymous Method",values);
    //         };
    //        print(100);
    //        print(200);
    //        Console.ReadKey();
    //    }
    //}
   
    //<<<<<<<<<<<<<<---------------------------------------------------------------------------------------->>>>>>>>>>>>//
    // Passing delegate in an Anonymous method

    class Program
    {
        public delegate void PrintValues(int values);
            static void Main(string[] hi)
            {
                
                PrintAllValues(delegate(int val)
                {
                    Console.WriteLine("{0} I am a delegate passed as parameter", val);
                },100);

            Console.ReadKey();
            }
           static void PrintAllValues(PrintValues print, int number)
            {
                print(500);
                Console.WriteLine("I am the value of delegate");
            }
            
        }
    }



