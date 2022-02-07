using KsiążkaTelefoniczna;


string userInput;

PhoneBook phoneBook = new PhoneBook();
phoneBook.Load();


do
{
    Console.WriteLine("===================================");
    Console.WriteLine("| Wybierz:                        |");
    Console.WriteLine("| 1. Dodaj kontakt                |");
    Console.WriteLine("| 2. Wyszukaj kontakt             |");
    Console.WriteLine("| 3. Wyświetl wszystkie kontakty  |");
    Console.WriteLine("| 0. Wyjście                      |");
    Console.WriteLine("===================================");

    userInput = Console.ReadLine();


    switch (userInput)
    {
        case "1":
            {
                phoneBook.AddPerson();
                break;
            }
        case "2":
            {
                phoneBook.SearchPerson();
                break;
            }
        case "3":
            {
                phoneBook.DisplayContacts();
                Console.WriteLine("Wciśnij dowolny klawisz aby wyjść");
                Console.ReadLine();
                break;
            }
        case "0":
            {
                break;
            }

        default:
            {
                Console.WriteLine("Zły numer");
                break;
            }

    }
    Console.Clear();
} while (userInput != "0");