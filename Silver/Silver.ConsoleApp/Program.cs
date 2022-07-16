using System;

namespace Silver.ConsoleApp
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //DType();
            BranchingEx1();
        }

        #region Basic

        private static void DType()
        {
            int a = 10;
            long l = 5000;
            ulong ul = 5555;
            short s = 32767;
            short sa = -32768;
            ushort ss = 65535;

            //Convert.ToInt32

            //string str = "123";
            // int i = int.Parse(str);
            //SOLID
            // f = (float) d;
            // implicit and explicit
            // type conversion
            // parsing
            // casting
        }

        #endregion Basic

        private static void BranchingEx1()
        {
            Console.WriteLine("Enter Number");
            var input = Console.ReadLine();
            var num = Convert.ToInt32(input);
            var res = "";

            //linq query ternary

            if (num % 2 == 0) Console.WriteLine("Even");
            else Console.WriteLine("Odd");

            var result = (num % 2 == 0) ? "Even" : "Odd";
        }

        private static void BranchEx2()
        {
            for (; ; )
            {
            }
            for (int i = 0; i < 10;)
            {
            }
            for (int i = 0; true; i++)
            {
            }
        }

        //loop known and unknown
        // do while while / known or unknown ( most prefer )
        // for loop and for each / known quantities

        private static void ClassAndObjects()
        {
            ClassAndObjects cs = new ClassAndObjects();
            ClassAndObjects css = new ClassAndObjects(5);
            ClassAndObjects cs1 = new ClassAndObjects(1, "");
            ClassAndObjects cs2 = new ClassAndObjects("", 1);
            cs = new ClassAndObjects();
        }
    }
}