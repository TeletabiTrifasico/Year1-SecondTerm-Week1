namespace assignment2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            program.Start();
        }
        void Start()
        {
            Person[] person = new Person[3];
            for (int i = 0; i < person.Length; i++)
            {
                person[i] = ReadPerson();
            }
            for (int i = 0; i < person.Length; i++)
            {
                PrintPerson(person[i]);
            }
        }
        Person ReadPerson()
        {
            Person person = new Person();

            person.FirstName = ReadString("Enter first name: ");
            person.LastName = ReadString("Enter last name: ");
            person.Gender = ReadGender("Enter gender (m/f): ");
            person.Age = ReadInt("Enter age: ");
            person.City = ReadString("Enter city: ");

            Console.WriteLine();

            return person;
        }
        void PrintPerson(Person p)
        {
            Console.Write($"{p.FirstName} {p.LastName} ");
            PrintGender(p.Gender);
            Console.WriteLine($"{p.Age} years old, {p.City}");
            Console.WriteLine();
        }
        GenderType ReadGender(string question)
        {
            while (true)
            {
                Console.Write(question);
                char input = Convert.ToChar(Console.ReadLine());
                if (input == 'f' || input == 'F')
                {
                    return GenderType.Female;
                }
                else if (input == 'm' || input == 'M')
                {
                    return GenderType.Male;
                }
                else
                {
                    Console.WriteLine("Enter 'm' or 'f'");
                }
            }
        }
        void PrintGender(GenderType gender)
        {
            if(gender == GenderType.Female)
            {
                Console.WriteLine($"(f)");
            }
            else
            {
                Console.WriteLine($"(m)");
            }
        }
        int ReadInt(string question)
        {
            Console.Write(question);
            int number = Convert.ToInt32(Console.ReadLine());
            return number;
        }
        int ReadInt(string question, int min, int max)
        {
            int number = ReadInt(question);
            while (true)
            {


                if (number > min && number < max)
                {
                    return number;
                }
                else
                {
                    number = ReadInt(question);
                }
            }
        }
        string ReadString(string question)
        {
            Console.Write(question);
            string input = Console.ReadLine();
            return input;
        }
    }
}