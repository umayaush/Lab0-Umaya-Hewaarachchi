using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Lab0_Umaya_Hewaarachchi
{
    internal class Program
    {

        // Task 1
        static void Main(string[] args)
        {
            double low = GetLowNum();
            double high = GetHighNum(low);
            double difference = high - low;
            Console.WriteLine($"The difference between {low} and {high} is {difference}.");
            List<double> numInBetween = GetNumbersInBetween(low, high, difference);
            WriteNumbersToFile(numInBetween);
            PrintPrimeNumbers(low, high);
        }

        // Task 2
        public static double GetLowNum()
        {
            Console.WriteLine("Enter a low number: ");
            double num = Convert.ToDouble(Console.ReadLine());
            while (num <= 0)
            {
                Console.WriteLine("Invalid input. Enter a positive number: ");
                num = Convert.ToDouble(Console.ReadLine());
            }
            return num;
        }

        public static double GetHighNum(double low)
        {
            Console.WriteLine("Enter a high number: ");
            double num = Convert.ToDouble(Console.ReadLine());
            while (num <= low)
            {
                Console.WriteLine($"Invalid input. Enter a number greater than {low}: ");
                num = Convert.ToDouble(Console.ReadLine());
            }
            return num;
        }

        // Task 3
        public static List<double> GetNumbersInBetween(double low, double high, double difference)
        {
            List<double> numbersBetween = new List<double>();
            for (double i = low + 1; i < high; i++)
            {
                numbersBetween.Add(i);
            }
            return numbersBetween;
        }

        // Additional Task
        public static void WriteNumbersToFile(List<double> numbers)
        {
            numbers.Reverse();
            string filePath = "numbers.txt";
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                foreach (var number in numbers)
                {
                    writer.WriteLine(number);
                }
            }
        }

        public static void PrintPrimeNumbers(double low, double high)
        {
            Console.WriteLine($"Prime numbers between {low} and {high}: ");
            for (double i = low; i <= high; i++)
            {
                if (IsPrime(i))
                {
                    Console.Write($"{i} ");
                }
            }
            Console.WriteLine();
        }

        public static bool IsPrime(double num)
        {
            if (num < 2)
                return false;
            for (int i = 2; i <= Math.Sqrt(num); i++)
            {
                if (num % i == 0)
                    return false;
            }
            return true;
        }
    }
}
