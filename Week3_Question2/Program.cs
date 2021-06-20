using System;

namespace Week3_Question2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Declare and initialize array of 10 integers.
            then print the multiplication table of each element in the array.
             */
            int[] array = new int[10];
            int i;

            for (i = 0; i <= 9; i++)
            {
                Console.WriteLine("Enter a multiplication");
                i = Convert.ToInt32(Console.ReadLine());
                {
                    Console.WriteLine(array[9]);
                }
            }
        }
    }
}
