using System;

namespace Silver.ConsoleApp
{
    public class Testing
    {
    }

    public class LivingThings
    {
        public LivingThings()
        {
        }

        public LivingThings(string name)
        {
        }

        protected LivingThings(int i)
        {
        }

        public string Name { get; set; }
        protected string protectedVariable { get; set; }
        private string privateVariable { get; set; }

        public virtual void Function()
        {
            Console.WriteLine("I am from living thing class");
            Name = "";
            privateVariable = "";
            protectedVariable = "";
        }
    }

    // a class can be inheritaed from only one class
    public class Animal : LivingThings
    {
        public Animal() : base()
        {
        }

        public Animal(string name) : base(name)
        {
        }

        public Animal(int i) : base(i)
        {
        }

        public override void Function()
        {
            Console.WriteLine("I am from animal class");
            Name = "";
            protectedVariable = "";
            //privateVariable = "";
            //base.Function();
        }
    }

    public class Plant : LivingThings
    {
        public Plant() : base("")
        {
        }

        public override void Function()
        {
            Console.WriteLine("I am from plant class");
        }
    }

    public class Vertibrates : Animal
    {
        public Vertibrates()
        {
        }
    }

    public class Invertibrates : Animal
    {
        public Invertibrates()
        {
        }
    }

    public class Human : Vertibrates
    {
        public Human()
        {
        }
    }

    //types of inheritance
    ///1. Single Inheritane
    ///a
    ///b:a
    ///
    ///2. Multiple Inheritance : possible with interface
    ///a
    ///b
    ///c:a,b
    ///
    ///3. Multi-Level Inheritance
    ///a
    ///b:a
    ///c:b
    ///
    ///4. Hierarchial Inheritance
    ///a
    ///b:a
    ///c:a
    ///
    ///5. Hybrid Inheritance
    ///mix of everything
}
