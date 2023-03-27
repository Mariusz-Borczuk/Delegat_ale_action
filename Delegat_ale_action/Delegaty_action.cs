using System;

namespace Delegaty
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj 2 liczby całkowite");
            int liczba1 = int.Parse(Console.ReadLine());
            int liczba2 = int.Parse(Console.ReadLine());

            Action<int, int> dodajMnoz = (l1,l2)=>
            {
                Console.WriteLine($"Dodawanie {l1 + l2}");
                Console.WriteLine($"Mnożenie {l1 * l2}");

            };
            Action<int, int> odejOdej = (l1, l2) =>
            {
                Console.WriteLine($"Odejmowanie Pierszej liczby od drugiej {l1  - l2}");
                Console.WriteLine($"Odejmowanie Drugiej liczby od pierwszej {l2 - l1}");

            };
            Action<int, int> inny = (l1, l2) =>
            {
                Console.WriteLine($"No i masz babo placek:{(l1 - l2) * 2 * l1 + l2}...");

            };

            do{
                Console.WriteLine("Podaj jakie działanie chcemy wykonać lub naciśnij Enter, aby zakończyć:");
                string jakieDzialanieRobimy = Console.ReadLine();

              
                if (string.IsNullOrEmpty(jakieDzialanieRobimy))
                {
                    Console.WriteLine("Program zakończył działanie.");
                    break;
                }

                Action<int, int> dzialania;

                switch (jakieDzialanieRobimy.ToLower())
                {
                    case ("d"):
                        dzialania = dodajMnoz;
                        break;
                    case ("o"):
                        dzialania = odejOdej;
                        break;
                    default:
                        dzialania = inny;
                        break;
                }

                dzialania(liczba1, liczba2);
                
            } while (true);
        }
    }
}
