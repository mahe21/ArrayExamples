﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayPrograms
{
    internal class DescendingOrder
    {
        public static void Descending()
        {
            int size, i, j, temp;


            Console.Write("Enter size of array : ");
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


                    if (arr[j] > arr[i])
                    {
                        temp = arr[j];
                        arr[j] = arr[i];
                        arr[i] = temp;
                    }
                }
            }


            Console.Write("\nElements of array in ascending order: ");
            for (i = 0; i < size; i++)
            {
                Console.Write("{0} ", arr[i]);
            }
            Console.ReadLine();
        }
    }
}
