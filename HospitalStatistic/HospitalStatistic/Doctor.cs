using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalStatistic
{
    internal class Doctor : Person
    {
        private int id;
        private float salary;
        private int daysInWork;
        public Doctor(int id, string name, string surname, int age, float salary, int daysInWork) : base(name, surname, age)
        {
            this.id = id;
            this.salary = salary;
            this.daysInWork = daysInWork;
        }
        public override string ToString()
        {
            return $"ID: {id}\n" + base.ToString() + $"\nSalary: {salary}\nDays in Work: {daysInWork}";
        }
        
        public float Salary
        {
            get { return salary; }
            set { salary = value; }
        }

        public int Id
        {
            get { return id; }
        }
    }
}
