using System;

namespace Silver.ConsoleApp
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var res = "n";
            do
            {
                //DataTypes();
                //Casting();
                //BranchingEx1();
                //BranchingEx2();
                //ForLoopExample();
                //ForEachExample();
                //LoopBreakAndContinue();
                //ClassAndObjectsExample();
                //PropertiesExample();
                //PropertiesExampleV2();
                //FunctionExample();
                OperatorOverloadingExample();

                Console.WriteLine("Do you want to continue more? (y/n)");
                res = Console.ReadLine();
            } while (res == "y");
        }

        #region Class And Objects

        private static void OperatorOverloadingExample()
        {
            int i = 10;
            int j = 20;
            int res = i + j;

            StudentInfo s1 = new StudentInfo(70, 80);
            StudentInfo s3 = new StudentInfo(70, 80);
            StudentInfo s2 = new StudentInfo(50, 60);
            StudentInfo s5 = new StudentInfo(20, 50);
            //var totalMath = s1.Math + s2.Math + s3.Math+s5.Math;
            //var totalScience = s1.Science + s2.Science + s3.Science +s5.Science;
            //var totalUpper = s1.Upper + s2.Upper + s3.Upper+s5.Upper;

            //StudentInfo s4 = s1 + s2 + s3 + s5 + 2;
            //StudentInfo s = 2 + s1;
            //s1++;

            s1 = s1 + 2;

            Console.WriteLine(s1 == s3);
        }

        private static void FunctionExample()
        {
            ClassAndObjects co = new ClassAndObjects();
            var a = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 10 };
            co.Add(1, 2, 3, 4, 5, 6, 7, 8, 10);

            co.FunctionTwo(1, "abc", DateTime.Now);
            co.FunctionTwo(a: 1, b: "abc", dt: DateTime.Now);
            co.FunctionTwo(dt: DateTime.Now, a: 1, b: "");
            //Console.Write()
            co.FunctionThree(1, 2);

            int x = 10, y = 20;
            ClassAndObjects.PassByValue(x, y);
            ClassAndObjects.PassByReference(ref x, ref y);
            ClassAndObjects.UsingOut(x, y, out y);
            var res = co.Subtract(10, 29);
            var res2 = co.Multiply(20, 10);
        }

        private static void PropertiesExampleV2()
        {
            StudentInfo si = new StudentInfo();
            //Console.WriteLine("Enter Marks in Math");
            //si.Math = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("Enter Marks in Science");
            //si.Science = Convert.ToDouble(Console.ReadLine());

            si.Math = -70;
            si.Science = 900;

            Console.WriteLine("=============================");
            Console.WriteLine($"Math : {si.Math}");
            Console.WriteLine($"Science : {si.Science}");
            Console.WriteLine($"Total : {si.Total}");
            Console.WriteLine($"Percentage : {si.Percentage}");
            Console.WriteLine($"Division : {si.Division}");

            si.Math = 55;
            si.Science = 40;
            Console.WriteLine("=============================");
            Console.WriteLine($"Math : {si.Math}");
            Console.WriteLine($"Science : {si.Science}");
            Console.WriteLine($"Total : {si.Total}");
            Console.WriteLine($"Percentage : {si.Percentage}");
            Console.WriteLine($"Division : {si.Division}");
        }

        private static void PropertiesExample()
        {
            StudentInfo si = new StudentInfo();
            Console.WriteLine("Enter the FirstName");
            si.FirstName = Console.ReadLine();
            Console.WriteLine("Enter the MiddleName");
            si.MiddleName = Console.ReadLine();
            Console.WriteLine("Enter the LastName");
            si.LastName = Console.ReadLine();

            Console.WriteLine("Full name is " + si.FullName);
        }

        private static void ClassAndObjectsExample()
        {
            ClassAndObjects cs = new ClassAndObjects();
            Console.WriteLine("hash => " + cs.GetHashCode());
            ClassAndObjects cs1 = new ClassAndObjects(1, "");
            ClassAndObjects cs2 = new ClassAndObjects("", 1);
            ClassAndObjects cs3 = new ClassAndObjects();
            ClassAndObjects cs4 = new ClassAndObjects();
            Console.WriteLine("hash => " + cs.GetHashCode());
            cs = new ClassAndObjects();
            Console.WriteLine("hash => " + cs.GetHashCode());

            cs.I = 10;
            Console.WriteLine(cs.I);
            //cs._code = 10 ;
            cs.SetCode("ajsdfa");
            // cs.Code = "asfasdf";
            Console.WriteLine(cs.Code);
            cs.Code = Console.ReadLine();
        }

        #endregion Class And Objects

        #region Control Statements

        //looping
        //known and unknown
        //do--while and while loop : unknown (most preferable) / known quantities
        //for loop and foreach : Known quantities
        private static void LoopBreakAndContinue()
        {
            {
                int i = 0;
                while (true)
                {
                    i++;
                    if (i == 10)
                    {
                        break;
                    }
                    Console.WriteLine(i);
                }
            }

            {
                string[] days = new string[] { "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" };
                for (int i = 0; i < days.Length; i++)
                {
                    if (days[i] == "Tuesday")
                    {
                        continue;
                    }
                    Console.WriteLine(days[i]);
                }
            }
        }

        private static void ForLoopExample()
        {
            string[] days = new string[] { "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" };
            for (int i = 0; i < days.Length; i++)
            {
                Console.WriteLine(days[i]);
            }
        }

        private static void ForEachExample()
        {
            string[] days = new string[] { "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" };
            foreach (var item in days)
            {
                Console.WriteLine(item);
            }
        }

        private static void InfiniteLooping()
        {
            //do-- while
            do
            {
            } while (1 < 2);

            int i = 0;
            do
            {
                //i++;
            } while (i < 10);

            while (true)
            {
            }

            for (; ; )
            {
            }

            for (int x = 0; x < 10;)
            {
            }
            for (int y = 0; true; y++)
            {
            }
        }

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

        private static void ArrayExample()
        {
            int[] ints = { 1, 2, 3, 4, 5, 6 };
            int[] i = new int[10];
        }

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
