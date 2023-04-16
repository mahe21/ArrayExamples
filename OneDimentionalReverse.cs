using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayPrograms
{
    internal class OneDimentionalReverse
    {
        public static void Reverse()
        {
            int[] num = { 22, 50, 11, 2, 49 };
            Array.Reverse(num);
            for (int i = 0; i < num.Length; i++)
            {
                Console.Write(num[i] + " ");
            }
        }
    }
}
