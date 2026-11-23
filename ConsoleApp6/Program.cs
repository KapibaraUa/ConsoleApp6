using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите 1 цифру: ");
            int d1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите 2 цифру: ");
            int d2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите 3 цифру: ");
            int d3 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите 4 цифру: ");
            int d4 = Convert.ToInt32(Console.ReadLine());

            int result = d1 * 1000 + d2 * 100 + d3 * 10 + d4;
            Console.WriteLine($"Результат: {result}");

            Console.WriteLine();

            Console.Write("Введите значение: ");
            double val = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите процент: ");
            double percent = Convert.ToDouble(Console.ReadLine());

            double res = (val * percent) / 100;
            Console.WriteLine($"Результат: {res}");
        }
    }
}