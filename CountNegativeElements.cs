using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayPrograms
{
    internal class CountNegativeElements
    {
        public static void TotalNegativeElements()
        {
            Console.Write("Enter the size of an array:");
            int Size = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[Size];
            int Count = 0;
            Console.WriteLine("Enter {0} of an array", Size);
            
            for (int i = 0; i < Size; i++)
            {
                arr[i]= Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0;i < Size; i++)
            {
                if (arr[i] < 0)
                {
                    Count++;
                }
            }
            Console.Write("total number of negative elements are {0} ", Count);
            Console.ReadLine();
        }
    }
}
