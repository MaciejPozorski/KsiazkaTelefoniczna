namespace KsiążkaTelefoniczna
{
    public class Person
    {
        private string name;
        private long number;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public long Number
        {
            get { return number; }
            set { number = value; }
        }

        public Person(string name, long number)
        {
            Name = name;
            Number = number;
        }

    }
}
