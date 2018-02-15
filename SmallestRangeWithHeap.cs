using System;
using System.Collections.Generic;
using System.Linq;
using QuickGraph.Collections;

namespace MS
{
    public class Node {
        public int Value;

        public int K;

        public int N;

        public Node(int value, int k,  int n) {
            Value = value;
            K = k;
            N = n;
        }
    }

    public class SmallestRangeWithHeap
    {
        public int[] SmallestRange(List<int[]> input, int n, int k) {
            Node minNode;
            int[] smallestRange = new int[0];
            int value, size, smallestSize = int.MaxValue;

            // Create a min heap since so we can quickly find the min
            var heap = new BinaryHeap<int, Node>((a, b) => a.CompareTo(b));

            // Initialize heap and find initial max
            int max = Enumerable.Range(0, k).Max( i => {
                value = input[i][0];
                heap.Add(value, new Node(value, i, 0));
                return value;
            });

            // Loop until the current smallest node is at the end of a list
            // This will run a maximum between n-1 and n*k-k times
            while(true) {
                // Find the smallest range
                minNode = heap.RemoveMinimum().Value;

                size = max - minNode.Value;

                if (size < smallestSize) {
                    smallestRange = new int[2] {minNode.Value, max};
                    smallestSize = size;
                }

                // See if we're at the end of a list
                if (minNode.N + 1 >= n) {
                    break;
                }

                // Build the next node to add
                value = input[minNode.K][minNode.N + 1];

                if (value > max) {
                    max = value;
                }

                heap.Add(value, new Node(value, minNode.K, minNode.N + 1));
            }

            return smallestRange;
        }
    }
}
