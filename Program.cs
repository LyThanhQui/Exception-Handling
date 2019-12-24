using System;

namespace ExeptionHandling
{
    class Program
    {
        // The below example shows program execution without exception
      /*  static void Main(string[] args)
        {      
                int a = 20;
                int b = 10;
                int c;
                Console.WriteLine("A VALUE = " + a);
                Console.WriteLine("B VALUE = " + b);
                c = a / b;
                Console.WriteLine("C VALUE = " + c);
                Console.ReadKey();    
        }
        */
        //The below example shows program execution with the exception
        static void Main(string[] args)
        {
            int a = 20;
            int b = 0;
            int c;
            Console.WriteLine("A VALUE = " + a);
            Console.WriteLine("B VALUE = " + b);
            c = a / b;
            Console.WriteLine("C VALUE = " + c);
            Console.ReadKey();
        }

    }
}
