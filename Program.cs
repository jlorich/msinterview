using System;
using System.Collections.Generic;
using System.Linq;

/*

Manual solution walkthrough:

4, 0, 5   --   0-5 = 5,
7, 0 ,5   --   0-7 = 7,
7, 8, 5   --   5-8 = 3,
7, 8, 11  --  7-11 = 4,
7, 8, 10  --  7-10  = 3
...

We'll want 


 */

namespace ms
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] arr = new int[3, 5] {
                {4, 7, 10, 12, 15},
                {0, 8, 9, 14, 20},
                {5, 11, 16, 30, 50}
            };

            int n = 5; // number of elements
            int k = 3; // number of lists

            // i is which list
            // j is which item
            
            int min = int.MaxValue;
            int max = 0;
            int[] smallest = new int[2];
            int smallestLength = int.MaxValue;

            var list = new List<int>();
            
            // Loop once for each item in the list
            for (int j = 0; j < n; j++) {
                
                // Loop once for each list building out the "heap"
                for (int i = 0; i < k; i++) {

                    if (j > 0) {
                        var toremove = arr[i, j - 1];
                        if (list.Contains(toremove)) {
                            list.Remove(toremove);
                        }
                    }
                    var item = arr[i,j];

                    list.Add(item);

                    min = list.Min();
                    max = list.Max();

                    if (min != max && max - min < smallestLength) {
                        smallestLength = max - min;
                        smallest = new int[2] { max, min};
                    }
                }
            }

            Console.Out.WriteLine(smallest);
        }
    }
}



// Find smallest range containing elements from k lists
// Given k sorted lists of integers of size n each, find the smallest range that includes at least one element from each of the k lists. If more than one smallest ranges are found, print any one of them.
// Example : 
// Input:
// K = 3
// arr1[] : [4, 7, 10, 12, 15]
// arr2[] : [0, 8, 9, 14, 20]
// arr3[] : [5, 11, 16, 30, 50]
// Output:
// The smallest range is [9 11] 
// Explanation: Smallest range is formed by 
// number 9 from second list, 10 from first
// list and 11 from third list.

