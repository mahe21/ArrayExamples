using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayPrograms
{
    internal class SumOfAnArray
    {
        public static void ArraySum()
        {
            Console.Write("Enter size of an array");
            int Size = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[Size];
            int Sum = 0;
            Console.WriteLine("Enter {0} elements of an array", Size);
            for (int i = 0; i < Size; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
           
            for (int i = 0;i < Size; i++)
            {
                Sum = Sum + arr[i];
            }
            Console.Write("Sum of an elements are {0}", Sum);
            Console.ReadLine();
        }
    }
}
