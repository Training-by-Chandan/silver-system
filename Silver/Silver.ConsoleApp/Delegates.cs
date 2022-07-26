using System;

namespace Silver.ConsoleApp
{
    public class Delegates
    {
        public delegate void MathOps(int a, int b);

        public event MathOps OnMathOpsCalled;

        public MathOps m;

        public void Run()
        {
            //Unicast();
            MultiCast();
        }

        public void MultiCast()
        {
            int i = 10;
            i = i + 5;
            i += 5;

            m = new MathOps(Add);
            m = m + Subtract;
            m += Multiply;
            m += Add;
            m += Divide;

            m(2, 3);
        }

        private void Unicast()
        {
            m = Add;
            m(2, 3);

            m = Subtract;
            m(2, 3);

            m = Multiply;
            m(2, 3);

            m = Divide;
            m(2, 3);
        }

        public void RunFromOutside()
        {
            m(2, 3);
            OnMathOpsCalled?.Invoke(2, 3);
        }

        public void Add(int a, int b)
        {
            Console.WriteLine($"Sum = {a + b}");
        }

        public void Subtract(int a, int b)
        {
            Console.WriteLine($"Differences = {a - b}");
        }

        public void Multiply(int x, int y)
        {
            Console.WriteLine($"Product = {x * y}");
        }

        public void Divide(int p, int q)
        {
            Console.WriteLine($"Quotient = {p / q}");
        }
    }
}
