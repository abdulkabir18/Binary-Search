int[] userArray = { 1, 2, 3, 4, 5 };
int find = 4;

int result = Recursion_BinarySearch(userArray, find, 0, userArray.Length - 1);

Console.WriteLine(result == -1 ? $"Target: {find} is not found in the collection" : $"Target: {find} is found at index of {result}");

int Recursion_BinarySearch(int[] myArray, int target, int firstIndex, int lastIndex)
{
    int middleIndex;

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
        return Recursion_BinarySearch(myArray, target, middleIndex + 1, lastIndex);
    }
    else
        return Recursion_BinarySearch(myArray, target, firstIndex, middleIndex - 1);

}