using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Silver.ConsoleApp
{
    public abstract class AbstractClass
    {
        public void FunctionOne()
        {
            Console.WriteLine("Call from 1");
        }

        public abstract void FunctionTwo();
    }

    //Indexer
    public class AbsExample : AbstractClass
    {
        public override void FunctionTwo()
        {
        }
    }
}
