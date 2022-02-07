namespace KsiążkaTelefoniczna
{
    public class Person
    {
        private string name;
        private int number;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int Number
        {
            get { return number; }
            set { number = value; }
        }

        public Person(string name, int number)
        {
            Name = name;
            Number = number;
        }

    }
}
