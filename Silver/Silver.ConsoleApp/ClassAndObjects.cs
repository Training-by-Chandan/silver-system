using System;

namespace Silver.ConsoleApp
{
    //class : Design / Blueprint
    //object : instance of the class
    /// <summary>
    ///
    /// </summary>
    public class ClassAndObjects
    {
        //constructor
        //1. special function
        //2. name should be same as that of class name
        //3. no return type
        //4. Runs only once in its life cycle
        //5. we can define multiple constructor but use only one to create a single object
        public ClassAndObjects()
        {
            //TODO later Kritim will do this
            System.Console.WriteLine("An object is created.");
            return;
        }

        public ClassAndObjects(int i)
        {
            //_code
            //todo dipesh will do this
            System.Console.WriteLine("Another constructor");
        }

        public ClassAndObjects(int x, string y)
        {
            System.Console.WriteLine("Another constructor");
        }

        public ClassAndObjects(string x, int y)
        {
            System.Console.WriteLine("Another constructor");
        }

        //variables
        public int I = 10;

        private string _code = "ABC";

        //properties
        public string GetCode()
        {
            return _code;
        }

        public void SetCode(string code)
        {
            _code = code;
        }

        public string Code
        {
            get { return _code; }
            set { _code = value; }
        }

        //functions / methods / actions
        public void FunctionOne(int a)
        {
            if (a == 0)
            {
                return;
            }
            if (a != 0)
            {
                Console.WriteLine(a);
            }
        }

        //public int Add(int a, int b) => a + b;
        //public int Add(int a, int b, int c)
        //{
        //    return a + b + c;
        //}
        //public void Add(int a)
        //{
        //    //return a++;
        //}
        //public int Add(int a, int b, int c, int d)
        //{
        //    return a + b + c + d;
        //}

        /// <summary>
        ///
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        public int Add(params int[] a)
        {
            var sum = 0;
            foreach (var item in a)
            {
                sum += item;
            }
            return sum;
        }

        /// <summary>
        /// Summary of this function
        /// </summary>
        /// <param name="a">age of a person</param>
        /// <param name="b">name of a person</param>
        /// <param name="dt">date of birth</param>
        public void FunctionTwo(int a, string b, DateTime dt)
        {
        }

        public void FunctionThree(int a, int b, string c = "xyz", string d = "abc", int x = 10)
        {
        }

        public static void PassByValue(int a, int b)
        {
            a++;
            b++;
        }

        public static void PassByReference(ref int a, ref int b)
        {
            a++;
            b++;
        }

        public static void UsingOut(in int a, int b, out int res)
        {
            //a++; //it is readonly because of in keyword
            b++;
            res = a + b;
        }

        public (int, string, string) Subtract(int a, int b)
        {
            return (a - b, "abc", "xyz");
        }

        public Tuple<int, bool> Multiply(int a, int b)
        {
            return new Tuple<int, bool>(a * b, true);
        }

        public StudentInfo Test(StudentInfo info)
        {
            info.Math = 10;
            info.Science = 20;
            return info;
        }

        //{
        //    return a + b;
        //}
        //delegates
        //events

        //destructor

        //inheritance
        //polymorphism
        //interface
        //abstract class
        //static class
        //Tuples
        //templates
        //parallel programming
    }
}
