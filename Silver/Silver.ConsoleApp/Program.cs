using System;

namespace Silver.ConsoleApp
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //DataTypes();
            //Casting();
            //BranchingEx1();
            BranchingEx2();
        }

        #region Control Statements

        private static void BranchingEx2()
        {
            Console.WriteLine("Enter the number of DAY");
            var num = Convert.ToInt32(Console.ReadLine());

            if (num == 1)
            {
                Console.WriteLine("Sunday");
            }
            else if (num == 2)
            {
                Console.WriteLine("Monday");
            }
            else if (num == 3)
            {
                Console.WriteLine("Tuesday");
            }
            else if (num == 4)
            {
                Console.WriteLine("Wednesday");
            }
            else if (num == 5)
            {
                Console.WriteLine("Thursday");
            }
            else if (num == 6)
            {
                Console.WriteLine("Friday");
            }
            else if (num == 7)
            {
                Console.WriteLine("Saturday");
            }
            else
            {
                Console.WriteLine("Not a valid day");
            }

            switch (num)
            {
                case 1:
                    Console.WriteLine("Sunday");
                    break;

                case 2:
                    Console.WriteLine("Monday");
                    break;

                case 3:
                    Console.WriteLine("Tuesday");
                    break;

                case 4:
                    Console.WriteLine("Wednesday");
                    break;

                case 5:
                    Console.WriteLine("Thursday");
                    break;

                case 6:
                    Console.WriteLine("Friday");
                    break;

                case 7:
                    Console.WriteLine("Saturday");
                    break;

                default:
                    Console.WriteLine("Not a valid day");
                    break;
            }

            if (num == 2 || num == 3 || num == 4 || num == 5 || num == 6)
            {
                Console.WriteLine("Weekdays");
            }
            else if (num == 7 || num == 1)
            {
                Console.WriteLine("Weekends");
            }
            else
            {
                Console.WriteLine("Not a valid one");
            }

            switch (num)
            {
                case 2:
                case 3:
                case 4:
                case 5:
                case 6:
                    Console.WriteLine("Weekdays");
                    break;

                case 7:
                case 1:
                    Console.WriteLine("Weekends");
                    break;

                default:
                    Console.WriteLine("Not a valid one");
                    break;
            }
        }

        private static void BranchingEx1()
        {
            Console.WriteLine("Enter the number");
            var num = Convert.ToInt32(Console.ReadLine());
            var res = "";

            if (num % 2 == 0)
            {
                res = "it is even number";
            }
            else
            {
                res = "It is odd number";
            }

            //(condition) ? <true value> : <false value> //linq queries
            var result = (num % 2 == 0) ? "Even" : "Odd";
            Console.WriteLine(res);
        }

        #endregion Control Statements

        #region Basic

        private static void Casting()
        {
            //implicit
            //char => int => long => float => double
            char c = 'C';
            int i = c;
            long l = i;
            float f = l;
            double d = f;

            //explicit
            f = (float)d;
            l = (long)f;
            i = (int)l;
            c = (char)i;

            string str = i.ToString();
            Program p = new();
            str = p.ToString();

            //parsing
            str = "123";
            i = int.Parse(str);
            f = 123.34f;
            str = f.ToString();
            i = int.Parse(str);
            int.TryParse(str, out i);

            //type conversion
            i = Convert.ToInt32("123");

            //object
            object o1 = i;
            o1 = "";

            var v1 = "";
            //v1 = 123;
            var v2 = "";
        }

        private static void DataTypes()
        {
            //int
            int i = 2;
            //uint
            uint ui = 4000000000;
            //long
            long l = 1000000000000000000;
            //ulong
            //short
            short s = -32768;
            //ushort
            ushort us = 65535;
            //float / Single
            float f = 2.092f;
            //double
            double d = 2.98d;
            //decimal
            decimal de = 6.78m;
            //byte
            byte b = 255;
            //bool
            bool bo = true;
            //char
            char c = 'C';
            //string
            string str = "ABCD";
            //datetime
            DateTime dt = DateTime.Now;

            int num = 'C';
        }

        #endregion Basic

        //SOLID
        //S : Single Responsibility Principle
        //O : Open - Closed Principle
        //L : Liskov Subsitution Principle
        //I : Interface Segregation Principle
        //D : Dependency Inversion Principle
    }
}