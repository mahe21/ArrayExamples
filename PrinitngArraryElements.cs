using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayPrograms
{
    internal class PrinitngArraryElements
    {
        public static void ArrayElements()
        {
            Console.Write("Enter the size of an array: ");
            int Size = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[Size];

            Console.WriteLine("Enter {0} elements in an array", Size);
                for (int i = 0; i < Size; i++) 
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.Write("Array elements are: ");
            for (int i = 0; i < Size; i++)
            {
                Console.Write("{0} ", arr[i]);
            }
            Console.ReadLine();
        }
    }
}
