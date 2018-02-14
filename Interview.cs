using System;
using System.Collections.Generic;
using System.Linq;

/*
Find smallest range containing elements from k lists
Given k sorted lists of integers of size n each, find the smallest range that includes at least one element from each of the k lists. If more than one smallest ranges are found, print any one of them.
Example : 
Input:
K = 3
arr1[] : [4, 7, 10, 12, 15]
arr2[] : [0, 8, 9, 14, 20]
arr3[] : [5, 11, 16, 30, 50]
Output:
The smallest range is [9 11] 
Explanation: Smallest range is formed by 
number 9 from second list, 10 from first
list and 11 from third list.


The logic to follow for each step should be as follows:

list,        range, size
4, 0, 5   --   0-5 = 5,
7, 0 ,5   --   0-7 = 7,
7, 8, 5   --   5-8 = 3,
7, 8, 11  --  7-11 = 4,
7, 8, 10  --  7-10  = 3
...

 */


namespace MS
{
    public static class Interview
    {
        public static int[] SmallestRange(List<int[]> input, int n, int k) {
            int[] smallest = new int[2];
            int smallestLength = int.MaxValue;
            var list = new List<int>();
            
            // Loop once for each item in the list
            for (int j = 0; j < n; j++) {
                
                // Loop once for each list building out the "heap"
                for (int i = 0; i < k; i++) {

                    if (j > 0) {
                        list.Remove(input[i][j-1]);
                    }

                    list.Add(input[i][j]);

                    var min = list.Min();
                    var max = list.Max();

                    if (min != max && max - min < smallestLength) {
                        smallestLength = max - min;
                        smallest = new int[2] { min, max};
                    }
                }
            }

            return smallest;
        }
    }
}


