/*Write a program that can prompt the user for details of two arrays (size 5 each) and then inform the user if the arrays have the same data*/


using System;

namespace Arrayssearch
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int [5];
            int[] b = new int[5];

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Enter freshman Age: ");
                a[i] = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter Sophomore Age");
                b[i] = int.Parse(Console.ReadLine());

                
            }


            for (int i = 0; i < 5; i++)
                if (a[i] == b[i])
            {
                Console.WriteLine(a[i] + " and " + b[i] + " Are Similar");
            }
        }
    }
}
