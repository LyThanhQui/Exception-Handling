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
        /* static void Main(string[] args)
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
         */
        //Handling exception using logical implementation
        /* static void Main(string[] args)
         {
             int a, b, c;
             Console.WriteLine("ENTER ANY TWO NUBERS");
             a = int.Parse(Console.ReadLine());
             b = int.Parse(Console.ReadLine());
             if (b == 0)
             {
                 Console.WriteLine("second number should not be zero");
             }
             else
             {
                 c = a / b;
                 Console.WriteLine("C VALUE = " + c);
             }
             Console.ReadKey();
         }*/
        //Program to handle an exception using try-catch implementation with the generic catch
        static void Main(string[] args)
        {
            int a, b, c;
            Console.WriteLine("ENTER ANY TWO NUBERS");
            try
            {
                a = int.Parse(Console.ReadLine());
                b = int.Parse(Console.ReadLine());
                c = a / b;
                Console.WriteLine("C VALUE = " + c);
            }
            catch
            {
                Console.WriteLine("error occured....");
            }
            Console.ReadKey();
        }


    }
}
