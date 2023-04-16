using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayPrograms
{
    internal class EvenAndOddCount
    {
        public static void TotalNoOfEvenOdd()
        {
            Console.Write("Enter the size of an array:");
            int Size = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[Size];
            int even = 0;
            int odd = 0;
            Console.WriteLine("Enter {0} of an array", Size);

            for (int i = 0; i < Size; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < Size; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    even++;
                }
                else
                {
                    odd++;
                }
            }
            Console.Write("total number of even elements are {0} ", even);
            Console.Write("total number of odd elements are {0} ", odd);
            Console.ReadLine();
        }
    }
}
