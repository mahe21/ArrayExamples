using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace ArrayPrograms
{
    internal class SecondLargest
    {
        public static void SecondLargestValue()
        {
            Console.Write("Enter the size of an array:");
            int Size = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[Size];
            int Max1, Max2;
            Console.WriteLine("Enter {0} of an array", Size);
            for (int i = 0; i < Size; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Max1 = Max2 = arr[0];
            for (int i = 1; i < Size; i++)
            {
                if (arr[i] > Max1)
                {
                    Max2 = Max1;
                    Max1 = arr[i];
                }
                else if (arr[i] > Max2 && arr[i] < Max1)
                {
                    Max2 = arr[i];
                }
            }
            Console.Write("First largest = {0}\n", Max1);
            Console.Write("Second largest = {0}", Max2);
            Console.ReadLine();
        }
    }
}
