using System;
using System.Collections.Generic;
using System.Linq;

namespace PhoneBook
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Kontakt> kontakt_list = new List<Kontakt>();
            while (true)
            {


                Console.WriteLine("Witaj, prosze wybrać co chcesz zrobić:");
                Console.WriteLine("1-Dodać kontakt");
                Console.WriteLine("2-Wyświetl kontakt(po podaniu numeru)");
                Console.WriteLine("3-Wyświtl wszystkie kontakty");
                Console.WriteLine("4-Wyświetl kontakt(po podaniu numeru)");
                string userInput = Console.ReadLine();


                



                switch (userInput)
                {

                    case "1":


                        Console.WriteLine("Podaj dane:");
                        Console.WriteLine("Nazwa:");
                        string userInputName = Console.ReadLine();

                        Console.WriteLine("Numer:");
                        string userInputNumber = Console.ReadLine();
                        int help_number = int.Parse(userInputNumber);

                        kontakt_list.Add(new Kontakt() {Name=userInputName, Number=help_number });
              
                        break;

                    case "2":
                        Console.WriteLine("Podaj numer:");
                        string userInputNumber_case2 = Console.ReadLine();
                        int help_number_case2;
                        bool success = int.TryParse(userInputNumber_case2, out help_number_case2);
                        int help_success = Convert.ToInt32(success);

                        if (help_success==1)
                        {
                            var result = kontakt_list.FirstOrDefault(n=>n.Number== help_number_case2);
                            Console.WriteLine($"Imie: {result.Name} Numer: {result.Number}");
                        }
                        else
                        {
                            Console.WriteLine("Invalid date");
                        }
                        break;
                    default:
                        break;
                }


            }


        }
    }
}
