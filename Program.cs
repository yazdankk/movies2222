using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Cinema_Project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int ageRating15 = 15;
            int ageRating12 = 12;
            int ageRating18 = 18;
            int sleep = 2000000000;
            int sleep2 = 800;

            Console.BackgroundColor = ConsoleColor.Black; Console.ForegroundColor = ConsoleColor.Blue;
            string[] movies =
                {
                "Rush (15)",
                "How I Live Now (15)",
                "Thor: The Dark World (12)",
                "Filth (18)",
                "Planes (U)"
                };
            Console.WriteLine("Welcome to Aquinas Multiplex \r\nWe are presently showing: \r\n1. Teenage Horror film (15) \r\n2. How I Live Now (15) \r\n3. Another Marvel Film (12) \r\n4. Filth (18) \r\n5. Planes (U)\r\n");
            Console.WriteLine("Enter the number of the film you wish to see: ");
            int numberFilm = Convert.ToInt32(Console.ReadLine());

            while (numberFilm < 1 || numberFilm > 5)
            {
                Console.WriteLine("Access denied – No such film\n");
                Console.WriteLine("Enter the number of the film you wish to see: ");
                numberFilm = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Enter your age: ");
            int age = Convert.ToInt32(Console.ReadLine());

            switch (numberFilm)
            {
                case 1:
                    if (age < ageRating15)
                    {
                        Console.WriteLine("\nYou are too young\nAccess Denied!");
                        Thread.Sleep(sleep);
                    }
                    else
                    {
                        Console.WriteLine("Access Granted");
                        Thread.Sleep(sleep2);
                    }
                    break;
                case 2:
                    if (age < ageRating15)
                    {
                        Console.WriteLine("\nYou are too young\nAccess Denied!");
                        Thread.Sleep(sleep);
                    }
                    else
                    {
                        Console.WriteLine("Access Granted");
                        Thread.Sleep(sleep2);
                    }
                    break;
                case 3:
                    if (age < ageRating12)
                    {
                        Console.WriteLine("\nYou are too young\nAccess Denied!");
                        Thread.Sleep(sleep);
                    }
                    else
                    {
                        Console.WriteLine("Access Granted");
                        Thread.Sleep(sleep2);
                    }
                    break;
                case 4:
                    if (age < ageRating18)
                    {
                        Console.WriteLine("\nYou are too young\nAccess Denied!");
                        Thread.Sleep(sleep);
                    }
                    else
                    {
                        Console.WriteLine("Access Granted");
                        Thread.Sleep(sleep2);
                    }
                    break;
                case 5:
                    Console.WriteLine("Access Granted");
                    Thread.Sleep(sleep2);
                    break;
            }

            DateTime currentDate = DateTime.Now;
            DateTime maxDate = currentDate.AddDays(7);

            DateTime chosenDate;
            bool isValidDate;

            do
            {
                Console.Write("What date do you want to watch this film? (e.g. 22/09/2024): ");
                string filmDate = Console.ReadLine();
                isValidDate = DateTime.TryParseExact(filmDate, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out chosenDate);

                if (!isValidDate || chosenDate <= currentDate || chosenDate > maxDate)
                {
                    Console.WriteLine("Access denied – Date is invalid or out of range.\n");
                }
            } while (!isValidDate || chosenDate <= currentDate || chosenDate > maxDate);

            Console.WriteLine("Here is your Ticket");

            Console.WriteLine("\nAquinas Multiplex");
            Thread.Sleep(sleep2);
            Console.WriteLine($"Film: {movies[numberFilm - 1]}");
            Console.WriteLine($"Date: {chosenDate:dd/MM/yyyy}");
            Console.WriteLine("Enjoy the film\n");

        }
    }
}