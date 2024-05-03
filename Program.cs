using System;

namespace _4
{
    internal class Program
    {
        static int _minNumber = 1;
        static int _maxNumber = 10;

        static void Main(string[] args)
        {
            int number = 1;

            Console.Write("Введите до какого числа: ");
            number = Convert.ToInt32(Console.ReadLine());

            WriteTabl(number);
        }

        static void WriteTabl(int maxNumber)
        {
            string finalResult = "  ";

            for (int i = 0; i < maxNumber; i++)
                finalResult += $"{i + 1}  ";

            finalResult += "\n";

            for (int i = 0; i < maxNumber; i++)
            {
                finalResult += $"{i + 1} ";

                for (int j = 1; j <= maxNumber; j++)
                    finalResult += $"{(i + 1) * j}" + (((i + 1) * j) / 10 > 0 ? " " : "  ");

                finalResult += "\n";
            }

            Console.WriteLine(finalResult);
        }
    }
}
