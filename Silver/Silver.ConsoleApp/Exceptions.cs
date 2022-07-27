using System;

namespace Silver.ConsoleApp
{
    public class Exceptions
    {
        public static void FunctionOne()
        {
            Console.WriteLine("Enter the size of array");
            var size = Convert.ToInt32(Console.ReadLine());

            if (size == 0)
            {
                throw new NumberZeroException("Zero is not allowed");
            }
            if (size <= 10)
            {
                throw new LessthanTenException("value should not be less than 10");
            }

            Console.WriteLine("Enter the number");
            var num = Convert.ToInt32(Console.ReadLine());

            int[] arr = new int[size];
            arr[10] = num;

            Console.WriteLine("All good");
        }

        public static void FunctionTwo()
        {
            FunctionOne();
        }

        
        public static void MainFunction()
        {
            FunctionTwo();
        }
    }

    public class NumberZeroException : Exception
    {
        public NumberZeroException() : base("Number cannot be zero")
        {
        }

        public NumberZeroException(string message) : base(message)
        {
        }
    }

    [Serializable] //attribute
    public class LessthanTenException : Exception
    {
        public LessthanTenException()
        { }

        public LessthanTenException(string message) : base(message)
        {
        }

        public LessthanTenException(string message, Exception inner) : base(message, inner)
        {
        }

        protected LessthanTenException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
}
