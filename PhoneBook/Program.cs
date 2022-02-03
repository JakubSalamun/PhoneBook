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
                Console.WriteLine("4-Wyświetl kontakt(po podaniu nazwy)");
                Console.WriteLine("5-Usówanie kontaktu(po podaniu numeru)");
                Console.WriteLine("x-Wyjście z programu)");
                string userInput = Console.ReadLine();


                



                switch (userInput)
                {
                    #region
                    case "1":


                        Console.WriteLine("Podaj dane:");
                        Console.WriteLine("Nazwa:");
                        string userInputName = Console.ReadLine();

                        Console.WriteLine("Numer:");
                        string userInputNumber = Console.ReadLine();
                        int help_number = int.Parse(userInputNumber);
                        if (userInputName.Length>3&& help_number<=9)
                        {
                            kontakt_list.Add(new Kontakt() { Name = userInputName, Number = help_number });
                        }

              
                        break;
                    #endregion
                    #region
                    case "2":
    
                            Console.WriteLine("Podaj numer:");
                            string userInputNumber_case2 = Console.ReadLine();
                            int help_number_case2;
                            bool success = int.TryParse(userInputNumber_case2, out help_number_case2);
                            int help_success = Convert.ToInt32(success);

                            if (help_success == 1)
                            {
                                var result = kontakt_list.FirstOrDefault(n => n.Number == help_number_case2);
                                Console.WriteLine($"Imie: {result.Name} Numer: {result.Number}");
                                
                            }
                            else
                            {
                                Console.WriteLine("Invalid date");
                            }
                        break;
                    #endregion
                    #region
                    case "3":
                        Console.WriteLine("Twoje kontakty ");
                        foreach (var item in kontakt_list)
                        {
                            Console.WriteLine($"Nazwa:{item.Name} Numer:{item.Number}");
                        }
                        break;
                    #endregion
                    #region
                    case "4":

                        Console.WriteLine("Podaj nazwe:");
                        string userInputName_case4 = Console.ReadLine();

                        var result_case4 = kontakt_list.Where(n => n.Name.Contains(userInputName_case4)).ToList();
                        foreach (var item in result_case4)
                        {
                            Console.WriteLine($"{item.Name}-{item.Number}");
                        }
                        break;
                    #endregion
                    #region
                    case "6":
                        Console.WriteLine("Podaj numer do usunięci:");
                        string userInputDeleteNumber = Console.ReadLine();
                        int help_delete_number = int.Parse(userInputDeleteNumber);
                        kontakt_list.RemoveAll(c => c.Number == help_delete_number);
                        break;
                    #endregion
                    case "x":
                        return;
                    default:
                        break;
                }


            }


        }
    }
}
