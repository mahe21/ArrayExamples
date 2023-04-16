using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayPrograms
{
    internal class SearchElement
    {
        public static void FindElement()
        {
            
            int size, i, toSearch, found;


            
            Console.Write("Enter size of array : ");
            size = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[size];

            
            Console.WriteLine("Enter {0} elements in the array", size);
            for (i = 0; i < size; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.Write("\nEnter element to search: ");
            toSearch = Convert.ToInt32(Console.ReadLine());

            
            found = 0;

            for (i = 0; i < size; i++)
            {
                
                if (arr[i] == toSearch)
                {
                    found = 1;
                    break;
                }
            }

            
            if (found == 1)
            {
                Console.Write("\n{0} is found at position {1}", toSearch, i + 1);
            }
            else
            {
                Console.Write("\n{0} is not found in the array", toSearch);
            }
            Console.ReadLine();
        }
    }
}
