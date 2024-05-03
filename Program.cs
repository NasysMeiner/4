using System;

namespace _4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите до какого числа: ");
            WriteTabl(Convert.ToInt32(Console.ReadLine()));//Ввод до какого числа будет вывод
        }

        static void WriteTabl(int maxNumber)
        {
            string finalResult = "  ";//Формирование таблицы с отступами

            for (int i = 0; i < maxNumber; i++)
                finalResult += $"{i + 1}  ";//Вывод простых чисел

            finalResult += "\n";

            for (int i = 0; i < maxNumber; i++)
            {
                finalResult += $"{i + 1} ";

                for (int j = 1; j <= maxNumber; j++)
                    finalResult += $"{(i + 1) * j}" + ((i + 1) * j / 10 > 0 ? " " : "  ");//Соблюдение отступов проверкой на целое после деления на 10

                finalResult += "\n";
            }

            Console.WriteLine(finalResult);//Вывод результата
        }
    }
}
