using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad1
{
    internal class Program
    {
        static void Main()
        {
            // INPUT

            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            // OUTPUT

            // AVERAGE
            Console.WriteLine("------------------------");

            Console.WriteLine("AVERAGE");
            float average = Average(numbers);
            Console.WriteLine($"Average: {average:f2}");
            Console.WriteLine("------------------------");

            // PRINT ALL
            Console.WriteLine("PRINT ALL");
            PrintAll(numbers);
            Console.WriteLine("------------------------");

            // NUM OF ZERO
            Console.WriteLine("NUM OF ZERO");
            Zero(numbers);
            Console.WriteLine("------------------------");

            // CLOSE TO AVG
            Console.WriteLine("CLOSE TO AVERAGE");
            CloseAvg(numbers, average);
            Console.WriteLine("------------------------");

            //PRINT ALL ELEMENTS
            Console.WriteLine("PRINT ALL ELEMENTS");
            PrintElements(numbers);
            Console.WriteLine("------------------------");
        }

        private static void PrintElements(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine($"numbers[{i}] = {numbers[i]}");
            }
        }
        private static void CloseAvg(int[] numbers, float average)
        {
            int closest = numbers[0];
            int index = 0;

            for (int i = 1; i < numbers.Length; i++)
            {
                if (Math.Abs(numbers[i] - average) < Math.Abs(closest - average))
                {
                    closest = numbers[i];
                    index = i;
                }
            }
            Console.WriteLine(closest);
        }
        private static void Zero(int[] numbers)
        {
            byte numOfZero = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == 0)
                {
                    numOfZero++;
                }
            }
            Console.WriteLine($"{numOfZero}");
        }
        private static void PrintAll(int[] numbers)
        {
            Console.Write(string.Join(", ", numbers));
            Console.WriteLine();
        }
        private static float Average(int[] numbers)
        {
            float sum = 0;
            float avg = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum = sum + numbers[i];
            }
            avg = sum / numbers.Length;
            return avg;

            //Console.WriteLine($"{avg}");
        }
    }
}
