using System;

namespace Silver.ConsoleApp
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            DataTypes();
        }

        private static void Casting()
        {
            //implicit
            //explicit
            //parsing
            //type conversion
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

        //SOLID
        //S : Single Responsibility Principle
        //O : Open - Closed Principle
        //L : Liskov Subsitution Principle
        //I : Interface Segregation Principle
        //D : Dependency Inversion Principle
    }
}