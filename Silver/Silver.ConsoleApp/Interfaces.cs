using System;

namespace Silver.ConsoleApp
{
    public interface IInterfaces
    {
        void FunctionOne();

        //public void FunctionFour()
        //{
        //    //do something here
        //}
    }

    public interface ITest
    {
        int FunctionTwo();
    }

    public interface IAbc
    {
        string FunctionThree(int a, int b);
    }

    public class TestClass : Testing, IAbc, ITest, IInterfaces
    {
        private int i = 10;

        private void privateFunction()
        {
        }

        public void FunctionOne()
        {
            //do it yourself
            privateFunction();
        }

        public string FunctionThree(int a, int b)
        {
            return "";
        }

        public int FunctionTwo()
        {
            return 1;
        }
    }

    public interface IShape
    {
        void Input();

        void Area();

        void Perimeter();
    }

    public class Square : IShape
    {
        private double length;

        public void Input()
        {
            Console.WriteLine("Enter the length");
            length = Convert.ToDouble(Console.ReadLine());
        }

        public void Area()
        {
            var area = Math.Pow(length, 2);
            Console.WriteLine($"Area = {area}");
        }

        public void Perimeter()
        {
            var perimeter = 4 * length;
            Console.WriteLine($"Periemeter = {perimeter}");
        }
    }

    public class Rectangle : IShape
    {
        private double length;
        private double breadth;

        public void Input()
        {
            Console.WriteLine("Enter the length");
            length = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the breadth");
            length = Convert.ToDouble(Console.ReadLine());
        }

        public void Area()
        {
            var area = length * breadth;
            Console.WriteLine($"Area = {area}");
        }

        public void Perimeter()
        {
            var perimeter = 2 * (length + breadth);
            Console.WriteLine($"Periemeter = {perimeter}");
        }
    }

    public class Circle : IShape
    {
        private double radius;

        public void Areas()
        {
        }

        public void Area()
        {
            var area = Math.PI * Math.Pow(radius, 2);
            Console.WriteLine($"Area = {area}");
        }

        public void Input()
        {
            Console.WriteLine("Enter the radius");
            radius = Convert.ToDouble(Console.ReadLine());
        }

        public void Perimeter()
        {
            var perimeter = 2 * Math.PI * radius;
            Console.WriteLine($"Perimeter = {perimeter}");
        }
    }
}
