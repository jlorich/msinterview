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
            var list = new List<int>();
            
            // Loop once for each item in the list
            for (int j = 0; j < n; j++) {
                
                // Loop once for each list building out the list
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


