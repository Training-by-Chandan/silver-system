using System;

namespace Silver.ConsoleApp
{
    public class CustomStack
    {
        public CustomStack()
        {
            this.container = new string[5];
        }

        public CustomStack(int size)
        {
            this.container = new string[size];
        }

        private string[] container;
        private int counter = -1;

        public void Push(string item)
        {
            if (counter < container.Length - 1)
            {
                counter++;
                container[counter] = item;
            }
            else
            {
                Console.WriteLine("Stack is full");
            }
        }

        public void Pop()
        {
            if (counter >= 0)
            {
                container[counter] = default(string);
                counter--;
            }
            else
            {
                Console.WriteLine("Stack is empty");
            }
        }

        public string this[int index]
        {
            get
            {
                return container[index];
            }
        }
    }

    public class CustomStack<T>
    {
        public CustomStack()
        {
            this.container = new T[5];
        }

        public CustomStack(int size)
        {
            this.container = new T[size];
        }

        private T[] container;
        private int counter = -1;

        public void Push(T item)
        {
            if (counter < container.Length - 1)
            {
                counter++;
                container[counter] = item;
            }
            else
            {
                Console.WriteLine("Stack is full");
            }
        }

        public void Pop()
        {
            if (counter >= 0)
            {
                container[counter] = default(T);
                counter--;
            }
            else
            {
                Console.WriteLine("Stack is empty");
            }
        }

        public T this[int index]
        {
            get
            {
                return container[index];
            }
        }
    }

    public class CustoStackV2
    {
        private string[] container = new string[0];

        public void Push(string item)
        {
            Array.Resize(ref container, container.Length + 1);
            container[container.Length - 1] = item;
        }

        public void Pop()
        {
            if (container.Length > 0)
            {
                Array.Resize(ref container, container.Length - 1);
            }
        }
    }
}
