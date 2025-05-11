// See https://aka.ms/new-console-template for more information
using System.Text;

Console.WriteLine("Rotate an array to the right by k steps");
Console.WriteLine("Write a C# method that rotates the elements of an integer array to the right by k steps. Each step moves the last element of the array to the front, shifting all other elements one position to the right. For example, given the input array [1, 2, 3, 4, 5, 6, 7] and k = 3, the result should be [5, 6, 7, 1, 2, 3, 4]. The method must handle cases where k is greater than the array length and must operate in-place with O(1) extra space and O(n) time complexity. You may not use built-in methods such as Array.Copy, LINQ, or helper libraries that simplify the rotation. Function signature: void Rotate(int[] nums, int k)");

int[] elements = new int[] { 1, 2, 3, 4, 5, 6, 7 };

const int k = 3;

Console.WriteLine("String rotate: " + Rotate(elements, k));

string Rotate(int[] nums, int k)
{
    string arrayRotated = "";

    if (k > nums.Length)
    {
        return arrayRotated;
    }

    //We have to rotate the same array
    //Reverse the whole array
    RotateCollection(nums,0, nums.Length);
    //Rverse the first k elements
    RotateCollection(nums, 0, k);
    //Reverse the last n(array.length) - k elements
    RotateCollection(nums, k, nums.Length);

    StringBuilder stringBuilder = new StringBuilder();

    foreach (var item in nums)
    {
        stringBuilder.Append(item);   
    }

    arrayRotated = stringBuilder.ToString();

    return arrayRotated;
}

void RotateCollection(int[] nums, int start, int end)
{
    for (int i = start; i < end; i++)
    {
        if (i <= end-1)
        {
            end--;
            var aux = nums[i];
            nums[i] = nums[end];
            nums[end] = aux;
        }
    }
}