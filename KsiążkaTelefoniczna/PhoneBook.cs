namespace KsiążkaTelefoniczna
{
    internal class PhoneBook
    {
        public List<Person> Persons { get; set; } = new List<Person>();
        public void Load()
        {
            Persons.Add(new Person("Adam", 123123123));
            Persons.Add(new Person("Maciej", 123654987));
            Persons.Add(new Person("Jan", 99999999));
            Persons.Add(new Person("Zbychu", 88888888));
            Persons.Add(new Person("Krzyś", 321654987));
        }

        private void ShowList(List<Person> ContactsList)
        {
            foreach (Person person in ContactsList)
            {
                Console.WriteLine($"Name: {person.Name}, number: {person.Number}");
            }
        }
        public void AddPerson()
        {
            Console.WriteLine("Podaj imie: ");
            string name = Console.ReadLine();
            Console.WriteLine("Podaj numer");
            long nr = long.Parse(Console.ReadLine());
            Persons.Add(new Person(name, nr));
            Console.ReadLine();
        }
        public void SearchPerson()
        {
            Console.WriteLine("Podaj szczegóły: ");
            string userSearchInput = Console.ReadLine();
            if (long.TryParse(userSearchInput, out long number))
            {
                var wantedPerson = Persons.Where(p => p.Number.ToString().Contains(number.ToString())).ToList();
                if (wantedPerson != null)
                {
                    ShowList(wantedPerson);
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Person not found");
                    Console.ReadLine();
                }
            }
            else
            {

                var wantedPerson = Persons.Where(p => p.Name.Contains(userSearchInput)).ToList();
                if (wantedPerson != null)
                {
                    ShowList(wantedPerson);
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Person not found");
                    Console.ReadLine();
                }
            }
        }

        public void DisplayContacts()
        {
            ShowList(Persons);
        }
    }
}
