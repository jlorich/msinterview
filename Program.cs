using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;


using QuickGraph.Collections;

namespace MS
{
    static class Program
    {
        static void Main(string [] args) {
            var largeCollection = new List<int[]>();
            var n = 50;
            var k = 1000;

            Random rnd = new Random();

            for(int i = 0; i < k; i++) {
                var next = new List<int>();

                for (int j = 0; j < n; j++) {
                    next.Add(rnd.Next());
                }

                next.Sort();

                largeCollection.Add(next.ToArray());
            }

            var smallestRangeFinderWithList = new SmallestRangeWithList();
            var smallestRangeFinderWithHeap = new SmallestRangeWithHeap();

            var watch = new Stopwatch();

            watch.Start();
            smallestRangeFinderWithList.SmallestRange(largeCollection, n, k);
            watch.Stop();

            Console.Out.WriteLine($"Completed list search in {watch.Elapsed}");
            
            watch.Reset();
            
            watch.Start();
            smallestRangeFinderWithHeap.SmallestRange(largeCollection, n, k);
            watch.Stop();

            Console.Out.WriteLine($"Completed heap search in {watch.Elapsed}");
        }
    }
}


