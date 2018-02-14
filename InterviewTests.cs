using System;
using System.Collections.Generic;
using Xunit;

namespace MS
{
    public class InterviewTests
    {
        [Fact]
        public void TestSmallestRange()
        {
            // Arrange
            var input = new List<int[]>() {
                new int[] {4, 7, 10, 12, 15},
                new int[] {0, 8, 9, 14, 20},
                new int[] {5, 11, 16, 30, 50}
            };

            // Act
            var result = Interview.SmallestRange(input, 5, input.Count);
            
            // Assert
            Assert.Equal(new int[]{9, 11}, result);
        }
    }
}
