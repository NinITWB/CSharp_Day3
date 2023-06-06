using System;
using WatchDive;

namespace Watch
{
    class Program
    {
        static void Main(string [] args)
        {
            
            int[] arrNum = new int[10];
            int n = arrNum.Length;
            Random rand = new Random();
            StopWatch estimateTime = new StopWatch();

            for (int i = 0; i < arrNum.Length; i++)
            {
                arrNum[i] = rand.Next(1, 100);
            }    

            Console.WriteLine("After: ");
            estimateTime.Start();
            SelectionSort(ref arrNum);
            estimateTime.Stop();
            Console.WriteLine($"Elapsed Time: {estimateTime.GetElapsedTime()} milliseconds");
            
        }

        static void SelectionSort(ref int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                int minElement = i;
                if (i + 1 >= arr.Length) continue;
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] < arr[minElement]) minElement = j;
                }
                int temp = arr[minElement];
                arr[minElement] = arr[i];
                arr[i] = temp;
            }
        }

        

        
    }
}
