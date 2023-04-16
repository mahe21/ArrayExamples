using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayPrograms
{
    internal class DeleteUniqueElements
    {
        public static void RemoveUniqueElements()
        {
            int i, j, k, size;            
            Console.Write("Enter size of array: ");
            size = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[size];            
            Console.WriteLine("Enter {0} elements in the array", size);
            for (i = 0; i < size; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }            
            for (i = 0; i < size; i++)
            {
                for (j = i + 1; j < size; j++)
                {
                    
                    if (arr[i] == arr[j])
                    {
                        
                        for (k = j; k < size - 1; k++)
                        {
                            arr[k] = arr[k + 1];
                        }

                        
                        size--;

                        
                        j--;
                    }
                }
            }            
            Console.Write("\nArray elements after deleting duplicates : ");
            for (i = 0; i < size; i++)
            {
                Console.Write("{0}\t", arr[i]);
            }
            Console.ReadLine();
        }
    }
}
