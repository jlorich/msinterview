
## Given Problem:

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


## Solution
The logic to follow for each step should be as follows:

list,        range, size
4, 0, 5   --   0-5 = 5,
7, 0 ,5   --   0-7 = 7,
7, 8, 5   --   5-8 = 3,
7, 8, 11  --  7-11 = 4,
7, 8, 10  --  7-10  = 3
...

## Execution

This program is written with .NET Core 2.0 and requires the runtime to be installed.

The `Main()` method of Program.cs will generate a large amout of sorted arrays and test them for performance.

`InterviewTests` Includes a suite of unit tests for validating several cases for both the heap and list based finders.

## Example Run

>Completed list search in 00:00:00.9562019

>Completed heap search in 00:00:00.3586363
