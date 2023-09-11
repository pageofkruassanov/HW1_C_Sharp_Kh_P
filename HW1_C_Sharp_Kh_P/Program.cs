using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace HW1_C_Sharp_Kh_P
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Work #1:
            Console.WriteLine("It's easy to win forgiveness for being wrong \nbeing right is what gets you into real trouble. \nBjarne Stroustrup\n\n");
            //Work #2:
            const int MAX_NUM = 5;
            int[] numArray = new int[MAX_NUM];

            for (int i = 0; i < MAX_NUM; i++)
            {
                int tempVal;
                Console.Write("Введите " + (i + 1) + " число: ");
                tempVal = Convert.ToInt32(Console.ReadLine());
                numArray[i] = tempVal;
            }
            // search for maximum value:
            int maxVal = numArray[0];

            for (int i = 1; i < MAX_NUM; i++)
            {
                if (maxVal < numArray[i])
                {
                    maxVal = numArray[i];
                }
            }
            Console.WriteLine("Max value: " + maxVal);
            // search for minimum value
            int minVal = numArray[0];

            for (int i = 1; i < MAX_NUM; i++)
            {
                if (minVal > numArray[i])
                {
                    minVal = numArray[i];
                }
            }
            Console.WriteLine("Min value: " + minVal);
            // sum of numbers:
            int sumNum = 0;

            for (int i = 0; i < MAX_NUM; i++)
            {
                sumNum += numArray[i];
            }
            Console.WriteLine("Sum of numbers: " + sumNum);

            // multiplying numbers:
            int multiNum = numArray[0];
            for (int i = 1; i < MAX_NUM; i++)
            {
                multiNum *= numArray[i];
            }
            Console.WriteLine("Result of multiplying numbers: " + multiNum + "\n\n\n");

            // Work #3:
            int num;
            Console.WriteLine("Введите 6-ти значное число: ");
            string numberStr = Console.ReadLine();

            char[] charArray = numberStr.ToCharArray();
            Array.Reverse(charArray);
            string reversedNumberStr = new string(charArray);
            num = int.Parse(reversedNumberStr);

            Console.WriteLine("Развернутое число: " + num);

            Console.ReadLine();
        }
    }
}
