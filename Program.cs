using System;

namespace Registration
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Vaccine Registration page.");
            Console.WriteLine("Please fill in your details below:");
            Console.WriteLine("");

            Console.Write("Your ID: ");
            string idn = Console.ReadLine();

            Console.Write("Your First Name: ");
            string name = Console.ReadLine();

            Console.Write("Your Surname: ");
            string surname = Console.ReadLine();

            Console.Write("Your Gender: ");
            string gender = Console.ReadLine();

            Console.Write("Your date of Birth: ");
            string dob = Console.ReadLine();

            Console.Write("Province: ");
            string prov = Console.ReadLine();

            Console.WriteLine("");

            Console.WriteLine("Summary of information submitted:");
            Console.WriteLine("ID: " + idn);
            Console.WriteLine("First Name: " + name);
            Console.WriteLine("Surname: " + surname);
            Console.WriteLine("Gender: " + gender);
            Console.WriteLine("DOB: " + dob);
            Console.WriteLine("Province: " + prov);
        }
    }
}
