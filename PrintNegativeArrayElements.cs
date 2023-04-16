using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayPrograms
{
    internal class PrintNegativeArrayElements
    {
        public static void NegativeElements()
        {
            Console.Write("Enter the size of an array: ");
            int Size = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[Size];

            Console.WriteLine("Enter {0} elements in an array",Size);
            for (int i = 0; i < Size; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.Write("All negative elements are: ");
            for (int i = 0;i < Size; i++)
            {
                if (arr[i] < 0)
                {
                    Console.WriteLine(arr[i]);
                }
            }


        }

    }
}
