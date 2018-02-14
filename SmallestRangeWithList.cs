using System;
using System.Collections.Generic;
using System.Linq;

using QuickGraph.Collections;

namespace MS
{
    public class SmallestRangeWithList
    {
        public int[] SmallestRange(List<int[]> input, int n, int k) {
            int[] smallest = new int[2];
            int smallestLength = int.MaxValue;

            // Keep record of max.  Since the arrays are sorted the numbers we see are 
            // always rising so it's easy to keep track of the max.
            int max = 0;

            // Create a list to store data we'll be working with
            var list = new List<int>();
            
            // Loop once for each item in the list
            for (int j = 0; j < n; j++) {
                
                // Loop once for each list building out the list
                for (int i = 0; i < k; i++) {

                    if (j > 0) {
                        list.Remove(input[i][j-1]);
                    }

                    var val = input[i][j];

                    if (val > max) {
                        max = val;
                    }

                    list.Add(val);

                    var min = list.Min();

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


