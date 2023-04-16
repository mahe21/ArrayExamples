using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayPrograms
{
    internal class ReverseArray
    {
        public static void ReverseElements()
        {
            int size;
            int i;            
            Console.Write("Enter size of array : ");
            size = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[size];            
            Console.WriteLine("Enter {0} elements in the array", size);
            for (i = 0; i < size; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }            
            Console.Write("\nArray in reverse order: ");
            for (i = size - 1; i >= 0; i--)
            {
                Console.Write("{0}\t", arr[i]);
            }


            Console.ReadLine();
        }
    }
}
