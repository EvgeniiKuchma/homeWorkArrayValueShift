using System;

namespace homeWorkФrray_value_shift
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            int userInputShitLeft = 0;
            int minValue = 1;
            int maxValue = 10;
            int digitalArraySize = 10;
            int temp = 0;

            int[] digitalArray = new int[digitalArraySize];

            for (int i = 0; i < digitalArray.Length; i++)
            {
                digitalArray[i] = random.Next(minValue, maxValue);
                Console.Write(digitalArray[i] + " ");
            }

            Console.WriteLine();

            Console.Write("Enter the value of the desired left shift: ");
            userInputShitLeft = Convert.ToInt32(Console.ReadLine());

            for (int j = 0; j < userInputShitLeft; j++)
            {
                temp = digitalArray[0];

                for (int i = 0; i < digitalArray.Length - 1; i++)
                {
                    digitalArray[i] = digitalArray[i + 1];
                }

                digitalArray[digitalArraySize - 1] = temp;
            }

            for (int i = 0; i < digitalArraySize; i++)
            {
                Console.Write(digitalArray[i] + " ");
            }
        }
    }
}
