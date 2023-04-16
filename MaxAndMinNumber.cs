using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayPrograms
{
    internal class MaxAndMinNumber
    {
        public static void HighAndLowValue()
        {
            Console.Write("Enter the size of an array:");
            int Size = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[Size];
            int Max, Min;
            Console.WriteLine("Enter {0} of an array", Size);
            for (int i = 0; i < Size; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Max = arr[0];
            Min = arr[0];
            for (int i = 1; i < Size; i++)
            {
                if (arr[i] > Max)
                {
                    Max = arr[i];
                }
                if (arr[i] < Min)
                {
                    Min = arr[i];
                }
            }
            Console.Write("Maximum value of an array is = {0}\n", Max);
            Console.Write("Minimum value of an array is = {0}", Min);
            Console.ReadLine();
        }
    }
}
