using System.Globalization;

namespace BinarySearch;

internal class Program
{
    public static void Main(string[] args)
    {
        List<int> numberList = new List<int>() {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 
            11, 12, 13, 14, 15, 16, 17, 18, 19, 
            20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 
            30, 31, 32, 33, 34, 35, 36, 37, 38, 39, 
            40, 41, 42, 43, 44, 45, 46, 47, 48, 49, 
            50, 51, 52, 53, 54, 55, 56, 57, 58, 59, 
            60, 61, 62, 63, 64, 65, 66, 67, 68, 69, 
            70, 71, 72, 73, 74, 75, 76, 77, 78, 79, 
            80, 81, 82, 83, 84, 85, 86, 87, 88, 89, 
            90, 91, 92, 93, 94, 95, 96, 97, 98, 99, 100 };
        
        int result = BinarySearch(numberList, 35);
        Console.WriteLine(result);
        result = BinarySearch(numberList, 90);
        Console.WriteLine(result);
        result = BinarySearch(numberList, 18);
        Console.WriteLine(result);
    }

    private static int BinarySearch(List<int> listOfNumbers, int numberToBeSearched)
    {
        int low = 0;
        int high = (listOfNumbers.Count - 1);

        while (low <= high)
        {
            int mid = (low + high) / 2;
            var guess = listOfNumbers[mid];
            if (guess == numberToBeSearched)
            {
                return 1;
            }

            if (guess > numberToBeSearched)
            {
                high = mid - 1;
            }
            
            if(guess < numberToBeSearched)
            {
                low = mid + 1;
            }
        }
        return 0;
    }
}     
