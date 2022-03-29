using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalStatistic
{
    internal class Person
    {
        private string name;
        private string surname;
        private int age;
        
        public Person(string name, string surname, int age)
        {
            this.Name = name;
            this.Surname = surname;
            this.Age = age;
        }

        public string Name
        {
            get { return name; }
            set 
            {
                if (value != "")
                    name = value;
                else
                    name = "None";
            }
        }

        public string Surname
        {
            get { return surname; }
            set
            {
                if (value != "")
                    surname = value;
                else
                    surname = "None";
            }
        }

        public int Age
        {
            get { return age; }
            set 
            { 
                if(value > 0 && value < 200)
                    age = value; 
                else
                    age = 0;
            }
        }

        public override string ToString()
        {
            return $"Full name: {name} {surname}"+
                $"\nAge: {age}";
        }
    }
}
