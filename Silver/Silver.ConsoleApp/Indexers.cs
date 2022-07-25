using System;
using System.Collections.Generic;

namespace Silver.ConsoleApp
{
    public class Months
    {
        private List<string> months = new List<string>() { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };

        public string this[int index]
        {
            get { return months[index]; }
            set { months[index] = value; }
        }

        public string this[string index]
        {
            get 
            {
                return months[Convert.ToInt32(index)]; 
            }
            //set
            //{
            //    months[Convert.ToInt32(index)] = value;
            //}
        }
    }
}
