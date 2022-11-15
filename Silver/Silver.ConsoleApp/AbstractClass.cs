using System;

namespace Silver.ConsoleApp
{
    public abstract class AbstractClass
    {
        public void FunctionOne()
        {
            Console.WriteLine("Call from 1");

            System.Console.WriteLine("Callingfromfunction one");
        }

        public abstract void FunctionTwo();
    }

    public class AbsExample : AbstractClass
    {
        public override void FunctionTwo()
        {
        }
    }

    public abstract class AShape
    {
        protected double area, perimeter;

        public void Area()
        {
            Console.WriteLine($"Area = {area}");
        }

        public void Perimeter()
        {
            Console.WriteLine($"Perimeter = {perimeter}");
        }

        public void GetInput()
        {
            getInput();
            calculate();
        }

        protected abstract void getInput();

        protected abstract void calculate();
    }

    public class SquareAbs : AShape
    {
        private double length;

        protected override void getInput()
        {
            Console.WriteLine("Enter the length");
            length = Convert.ToDouble(Console.ReadLine());
        }

        protected override void calculate()
        {
            area = Math.Pow(length, 2);
            perimeter = 4 * length;
        }
    }

    public class RectangleAbs : AShape
    {
        private double length, breadth;

        protected override void getInput()
        {
            Console.WriteLine("Enter the length");
            length = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the breadth");
            breadth = Convert.ToDouble(Console.ReadLine());
        }

        protected override void calculate()
        {
            area = length * breadth;
            perimeter = 2 * (length + breadth);
        }
    }
}
