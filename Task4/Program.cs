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


            // second function in the same task
            int[] numArray2 = new int[] { 10, 2, -2, -20, 10 };
            int k2 = -10;
            for (int i = 0; i < numArray2.Length; i++)
            {
                for (int j = i; j < numArray2.Length; j++)
                {
                    if ((numArray[i] + numArray2[j]) == k2)
                    {
                        int[] newArray2 = new int[] { i, j };
                        Console.WriteLine("[" + newArray2[0] + "," + newArray2[1] + "] ");
                    }
                }

            }


        }

    }
}
