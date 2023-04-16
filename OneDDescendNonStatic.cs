using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayPrograms
{
    internal class OneDDescendNonStatic
    {
        
        public void SortArray(int[] numarray)
        {
            int swap = 0;
            for (int i = 0; i < numarray.Length; i++)
            {
                for (int j = i + 1; j < numarray.Length; j++)
                {
                    if (numarray[i] <= numarray[j])
                    {
                        swap = numarray[j];
                        numarray[j] = numarray[i];
                        numarray[i] = swap;
                    }
                }
                Console.Write(numarray[i] + " ");
            }
        }
    }
}
