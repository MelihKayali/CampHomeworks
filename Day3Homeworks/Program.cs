using System;

namespace RefAndOutKeywords // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ref key value
            int number = 3;
            Console.WriteLine("Start value: {0}", number);
            square(number);
            Console.WriteLine("After the Square() : {0}", number);
            square2(ref number);
            Console.WriteLine("After the Square2() : {0}", number);


            //Out key value
            int numberOut;
            ChangeOut(out numberOut);
            Console.WriteLine(numberOut);

            int numberRef = 0;
            ChangeRef(ref numberRef);
            Console.WriteLine(numberRef);
        }

        static void ChangeRef(ref int numberRef)
        {
            numberRef = 1234;
        }

        static void ChangeOut(out int numberOut)
        {
            numberOut = 1234;
        }

        static void square(int number)
        {
            number = number * number;
        }

        static void square2(ref int number)
        {
            number = number * number;

        }
    }
}