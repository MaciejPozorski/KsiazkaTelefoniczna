using KsiążkaTelefoniczna;


string userInput;
string userSearchInput;
static List<Person> Getpeople()
{
    List<Person> people = new List<Person>()
    {
        new Person("Maciej", 123456789),
        new Person("Jan", 987654321),
        new Person("Adam", 789456123),
        new Person("zbychu", 481234567)
    };
    return people;
}

List<Person> people = Getpeople();


  void ShowAll()
  {
    foreach (Person person in people)
    {
        Console.WriteLine($"Name: {person.Name}, number: {person.Number}");
        
    }
  }

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
                Console.WriteLine("Podaj imie: ");
                string name = Console.ReadLine();
                Console.WriteLine("Podaj numer");
                int nr = int.Parse(Console.ReadLine()); 
                people.Add(new Person(name, nr));
                Console.WriteLine("ok");
                Console.ReadLine();
                break;
            }
        case "2":
            {
                Console.WriteLine("Podaj szczegóły: ");
                userSearchInput = Console.ReadLine();
                if (int.TryParse(userSearchInput, out int x))
                {
                    bool wanted (Person person)
                    {
                        return person.Number == x;
                    }

                    Person wantedPerson = people.FirstOrDefault(wanted);
                    if (wantedPerson != null)
                    {
                        Console.WriteLine($"Name: {wantedPerson.Name}, number: {wantedPerson.Number}");
                        Console.ReadLine ();
                    }
                    else
                    {
                        Console.WriteLine("Person not found");
                        Console.ReadLine ();
                    }
                }
                else
                {
                    bool wanted(Person person)
                    {
                        return person.Name == userSearchInput;
                    }

                    Person wantedPerson = people.FirstOrDefault(wanted);
                    if (wantedPerson != null)
                    {
                        Console.WriteLine($"Name: {wantedPerson.Name}, number: {wantedPerson.Number}");
                        Console.ReadLine();
                    }
                    else
                    {
                        Console.WriteLine("Person not found");
                        Console.ReadLine();
                    }
                }
                break;
            }
        case "3":
            {
                ShowAll();
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