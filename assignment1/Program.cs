using System;

namespace assignment1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program myProgram = new Program();
            myProgram.Start();
        }
        void Start()
        {
            PrintMonth();
            Console.WriteLine();
            Console.Write(ReadMonth("Enter a month number: "));
        }
        void PrintMonth(Months month)
        {
            Console.WriteLine($"{(int)month,2}. {month}");
        }
        void PrintMonth()
        {
            for (int i = 1; i<= 12; i++)
            {
                Months currentMonth = new Months();
                currentMonth = (Months)i;
                PrintMonth(currentMonth);
            }
        }
        Months ReadMonth(string question)
        {
            do
            {
                Console.Write(question);
                int number = Convert.ToInt32(Console.ReadLine());

                if (Enum.IsDefined(typeof(Months), number))
                {
                    Console.Write(number + " => ");
                    return (Months)number;
                }
                else
                {
                    Console.WriteLine($"{number} is not a valid value.");
                }
            }while (true);
        }
    }
}