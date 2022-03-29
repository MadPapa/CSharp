using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalStatistic
{
    internal class Patient : Person
    {

        private int id;
        private int daysInHospital;
        public Patient(int id, string name, string surname, int age, int daysInHospital) : base(name, surname, age)
        {
            this.id = id;
            this.daysInHospital = daysInHospital;
        }
        public override string ToString()
        {
            return $"ID: {id}\n" + base.ToString() + $"\nDays in Hospital: {daysInHospital}";
        }
    }
}
