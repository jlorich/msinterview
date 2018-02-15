using System;
using System.Collections.Generic;
using Xunit;

namespace MS
{
    public class InterviewTests
    {
        // Looks for a correct result among 3 sorted lists
        [Fact]
        public void TestSmallestRangeUsingList()
        {
            // Arrange
            var rangeFinder = new SmallestRangeWithList();

            var input = new List<int[]>() {
                new int[] {4, 7, 10, 12, 15},
                new int[] {0, 8, 9, 14, 20},
                new int[] {5, 11, 16, 30, 50}
            };

            // Act
            var result = rangeFinder.SmallestRange(input, input[0].Length, input.Count);
            
            // Assert
            Assert.Equal(new int[]{9, 11}, result);
        }

        // Looks for a correct result among 3 sorted lists when some numbers appear multiple times
        [Fact]
        public void TestSmallestRangeUsingListWithduplicates()
        {
            // Arrange
            var rangeFinder = new SmallestRangeWithList();

            var input = new List<int[]>() {
                new int[] {4, 7, 10, 12, 12, 12, 15},
                new int[] {0, 8, 9, 14, 14, 14, 20},
                new int[] {5, 11, 14, 15, 16, 30, 50}
            };

            // Act
            var result = rangeFinder.SmallestRange(input, input[0].Length, input.Count);
            
            // Assert
            Assert.Equal(new int[]{9, 11}, result);
        }

        // Looks for a correct result among 3 sorted lists
        [Fact]
        public void TestSmallestRangeUsingHeap()
        {
            // Arrange
            var rangeFinder = new SmallestRangeWithHeap();

            var input = new List<int[]>() {
                new int[] {4, 7, 10, 12, 15},
                new int[] {0, 8, 9, 14, 20},
                new int[] {5, 11, 16, 30, 50}
            };

            // Act
            var result = rangeFinder.SmallestRange(input, input[0].Length, input.Count);
            
            // Assert
            Assert.Equal(new int[]{9, 11}, result);
        }

        // Looks for a correct result among 3 sorted lists when some numbers appear multiple times
        [Fact]
        public void TestSmallestRangeUsingHeapWithDuplicates()
        {
            // Arrange
            var rangeFinder = new SmallestRangeWithHeap();

            var input = new List<int[]>() {
                new int[] {4, 7, 10, 12, 12, 12, 15},
                new int[] {0, 8, 9, 14, 14, 14, 20},
                new int[] {5, 11, 14, 15, 16, 30, 50}
            };

            // Act
            var result = rangeFinder.SmallestRange(input, input[0].Length, input.Count);
            
            // Assert
            Assert.Equal(new int[]{14, 15}, result);
        }

        // Looks for a correct result among 3 sorted lists with a very small sample size
        [Fact]
        public void TestSmallestRangeUsingHeapMinimumSize()
        {
            // Arrange
            var rangeFinder = new SmallestRangeWithHeap();
            
            var input = new List<int[]>() {
                new int[] {4},
                new int[] {0},
                new int[] {5}
            };

            // Act
            var result = rangeFinder.SmallestRange(input, input[0].Length, input.Count);
            
            // Assert
            Assert.Equal(new int[]{0, 5}, result);
        }
    }
}
