using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography;

namespace assignment0
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
            int value = ReadInt("Enter a value: ");
            Console.WriteLine($"You entered {value}.");

            int age = ReadInt("How old are you? ", 0, 120);
            Console.WriteLine($"You are {age} years old.");

            string name = ReadString("What is your name? ");
            Console.WriteLine($"Nice meeting you {name}.");
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