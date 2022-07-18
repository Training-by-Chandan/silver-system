using System;

namespace Silver.ConsoleApp
{
    //every members should be statis
    public static class StaticClass
    {
        static StaticClass()
        {
        }

        public static int I;

        public static void FunctionOne()
        {
        }
    }

    public class NonStaticClass
    {
        public int I;
        public static int IStatic;

        public void Function()
        {
            I++;
            IStatic++;
        }

        public static void StaticFunction()
        {
            //I++;
            IStatic++;
        }
    }
}
