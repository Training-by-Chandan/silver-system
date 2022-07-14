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
            System.Console.WriteLine("An object is created.");
        }

        public ClassAndObjects(int i)
        {
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
        //properties
        //functions / methods / actions

        //delegates
        //events

        //destructor
    }

    //inheritance
    //polymorphism
    //interface
    //abstract class
    //static class
    //Tuples
    //templates
    //parallel programming
}