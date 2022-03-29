using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalStatistic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Patient> patients = new List<Patient>();
            patients.Add(new Patient(1, "Jan", "Nowak", 100, 12));
            patients.Add(new Patient(2, "Antoni", "Bosak", 77, 28));
            patients.Add(new Patient(3, "Marianna", "Zbiciak", 67, 33));

            List<Doctor> doctors = new List<Doctor>();
            doctors.Add(new Doctor(1, "Izabela", "Kolanowska", 25, 3230.22f, 80));
            doctors.Add(new Doctor(2, "Mariusz", "Rakal", 35, 5460.80f, 120));

            Hospital hospital = new Hospital(patients, doctors);
            hospital.IncreaseSalary(1, 200);
            hospital.DisplayPatients();
            hospital.DisplayDoctors();

            hospital.DeleteDoctor(1);
            hospital.DisplayDoctors();

            Console.ReadKey();

        }
    }
}
