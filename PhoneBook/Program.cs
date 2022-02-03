using System;
using System.Collections.Generic;

namespace PhoneBook
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Witaj, prosze wybrać co chcesz zrobić:");
            Console.WriteLine("1-Dodać kontakt");
            Console.WriteLine("2-Wyświetl numer(po podaniu numeru)");
            Console.WriteLine("3-Wyświtl wszystkie kontakty");
            Console.WriteLine("4-Wyświetl kontakt(po podaniu numeru)");
            string userInput = Console.ReadLine();


            List<Kontakt> kontakt_list = new List<Kontakt>();
            while (true)
            {


                switch (userInput)
                {

                    case "1":


                        Console.WriteLine("Podaj dane:");
                        Console.WriteLine("Nazwa:");
                        string userInputName = Console.ReadLine();

                        Console.WriteLine("Numer:");
                        string userInputNumber = Console.ReadLine();
                        int help_number = int.Parse(userInputNumber);

                        kontakt_list.Add(new Kontakt(userInputName, help_number));
                        break;

                    default:
                        break;
                }

            }



        }
    }
}
