using System;

namespace Silver.ConsoleApp
{
    //class : Design / Blueprint
    //object : instance of the class
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
