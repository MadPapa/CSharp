using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalStatistic
{
    internal class Hospital
    {
        List<Patient> patients;
        List<Doctor> doctors;
        
        public Hospital(List<Patient> patients, List<Doctor>doctors)
        {
            this.patients = patients;
            this.doctors = doctors;
        }

        public void DisplayPatients()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Patients:");
            Console.ResetColor();
            foreach (Patient patient in patients)
            {
                Console.WriteLine(patient);
                Console.WriteLine();
            }
        }
        public void DisplayDoctors()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Doctors:");
            Console.ResetColor();
            foreach (Doctor doctor in doctors)
            {
                Console.WriteLine(doctor);
                Console.WriteLine();
            }
        }
        public void IncreaseSalary(int id, int howMuch)
        {

            bool isInHospital = false;
            foreach (Doctor doctor in doctors)
            {
                if (doctor.Id == id)
                {
                    isInHospital = true;
                    if (howMuch < 0)
                        return;
                    else
                        doctor.Salary += howMuch;
                }
            }
            if (!isInHospital)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("This doctor doesn't exist.\n");
                Console.ResetColor();
            }
        }
        public void DeleteDoctor(int id)
        {
            bool isInHospital = false;
            foreach (Doctor doctor in doctors)
            {
                if (doctor.Id == id)
                {
                    isInHospital = true;
                    doctors.Remove(doctor);
                    break;
                }
            }
            if (!isInHospital)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("This doctor doesn't exist.\n");
                Console.ResetColor();
            }
        }
    }
}
