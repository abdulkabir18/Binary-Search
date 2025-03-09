// Texting Values
int[] userArray = { 1, 2, 3, 4, 5 };
int find = 4;

// Invoking or Calling of the method
int result = Recursion_BinarySearch(userArray, find, 0, userArray.Length - 1);

// Printing the result to the console
Console.WriteLine(result == -1 ? $"Target: {find} is not found in the collection" : $"Target: {find} is found at index of {result}");

// Declearation of method
int Recursion_BinarySearch(int[] myArray, int target, int firstIndex, int lastIndex)
{
    int middleIndex;

    // Base case
    if (firstIndex > lastIndex)
    {
        return -1;
    }
    
    middleIndex = (firstIndex + lastIndex) / 2;

    if (myArray[middleIndex] == target)
    {
        return middleIndex;
    }
    else if (target > myArray[middleIndex])
    {
        // Recursive Call
        return Recursion_BinarySearch(myArray, target, middleIndex + 1, lastIndex);
    }
    else
        // Recursive Call
        return Recursion_BinarySearch(myArray, target, firstIndex, middleIndex - 1);

}

// This is how recursion works in the context of binary search, breaking the problem into smaller subproblems each time.
