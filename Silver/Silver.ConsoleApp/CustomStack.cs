using System;

namespace Silver.ConsoleApp
{
    public class CustomStack
    {
        private string[] container = new string[5];
        private int counter = -1;

        public void Push(string item)
        {
            if (counter < 4)
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
    }
}
