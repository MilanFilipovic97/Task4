using System;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numArray = new int[] { 10, 35, 45, 20, 25, 55 };
            int k = 45; // declared number 
            for (int i = 0; i < numArray.Length; i++)
            {
                for (int j = i; j < numArray.Length; j++)
                {
                    if ((numArray[i] + numArray[j]) == k)
                    {
                        int[] newArray = new int[] { i, j };
                        Console.WriteLine("[" + newArray[0] + "," + newArray[1] + "] ");
                    }
                }

            }

            //Console.WriteLine("Hello World!");

        }
    }
}
