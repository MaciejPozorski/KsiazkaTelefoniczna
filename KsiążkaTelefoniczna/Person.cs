using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KsiążkaTelefoniczna
{
    public class Person
    {
        private string name;
        private int number;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int Number
        {
            get { return number; }
            set 
            {
                if (value.ToString().Length == 9 || value.ToString().Length == 11)
                {
                number = value; 
                }
                else
                {
                Console.WriteLine("invalid value");
                }
            }
        }

        public Person(string name, int number)
        {
            Name = name;
            Number = number;
        }
        
    }
}
