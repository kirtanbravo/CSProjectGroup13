using System;

namespace HealthApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter first name: ");
            string firstName = Console.ReadLine();

            Console.Write("Enter last name: ");
            string lastName = Console.ReadLine();

            Console.Write("Enter weight in kilograms: ");
            double weight = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter height in centimeters: ");
            double height = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter systolic pressure (upper number): ");
            int systolic = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter diastolic pressure (lower number): ");
            int diastolic = Convert.ToInt32(Console.ReadLine());

            // Create patient object with firstName, lastName, weight, height
            Patient patient = new Patient(firstName, lastName, weight, height);

            // Display patient info
            Console.WriteLine("\n--- Patient Information ---");
            patient.DisplayInfo(systolic, diastolic);

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
