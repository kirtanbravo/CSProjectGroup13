using HealthApp;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Numerics;
using System.Reflection.Metadata;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace HealthApp
{
    internal class Patient
    {
        // Properties
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double Weight { get; set; } // in kg
        public double Height { get; set; } // in cm

        // Constructor
        public Patient(string firstName, string lastName, double weight, double height)
        {
            FirstName = firstName;
            LastName = lastName;
            Weight = weight;
            Height = height;
        }

        // Method to check blood pressure with detailed categories
        public string CheckBloodPressure(int systolic, int diastolic)
        {
            if (systolic > 180 || diastolic > 120)
                return "Hypertensive Crisis (consult your doctor immediately)";
            else if (systolic >= 140 || diastolic >= 90)
                return "High Blood Pressure (Hypertension) Stage 2";
            else if ((systolic >= 130 && systolic <= 139) || (diastolic >= 80 && diastolic <= 89))
                return "High Blood Pressure (Hypertension) Stage 1";
            else if (systolic >= 120 && systolic <= 129 && diastolic < 80)
                return "Elevated";
            else if (systolic < 120 && diastolic < 80)
                return "Normal";
            else if (systolic < 90 || diastolic < 60)
                return "Low Blood Pressure (Hypotension)";
            else
                return "Invalid Blood Pressure Reading";
        }

        // Private method to calculate BMI
        private double CalculateBMI()
        {
            double heightInMeters = Height / 100.0;
            return Weight / (heightInMeters * heightInMeters);
        }

        // Public method to display patient info
        public void DisplayInfo(int systolic, int diastolic)
        {
            Console.WriteLine("Patient Name: " + FirstName + " " + LastName);
            Console.WriteLine("Weight: " + Weight + " kg");
            Console.WriteLine("Height: " + Height + " cm");

            string bpResult = CheckBloodPressure(systolic, diastolic);
            Console.WriteLine("Blood Pressure Result: " + bpResult);

            double bmi = CalculateBMI();
            Console.WriteLine("BMI: " + bmi.ToString("F2"));

            if (bmi >= 25.0)
                Console.WriteLine("BMI Status: Overweight");
            else if (bmi >= 18.5)
                Console.WriteLine("BMI Status: Normal (Healthy)");
            else
                Console.WriteLine("BMI Status: Underweight");
        }
    }
}
