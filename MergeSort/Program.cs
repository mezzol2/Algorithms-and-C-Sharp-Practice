class Program
{
    public static void Main(string[] args)
    {
        //initialize an array to sort
        int[] numbers = { 2, 3, 6, 29, 109, 8987, 298, 129, 42, -3, 92, 11 };

        //sort the array
        MergeSort(numbers);

        //print the numbers in the array to check
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.WriteLine(numbers[i]);
        }
    }

    static int[] MergeSort(int[] numbers)
    {
        if (numbers is null || numbers.Length <= 1)
            return numbers;

        int halfway = numbers.Length / 2;

        //initialize left and right arrays
        int[]? leftArray = null;
        int[]? rightArray = null;

        //check if we have an even or odd number of elements in the array
        if (numbers.Length % 2 == 0)
        {  //even case
            leftArray = MergeSort(new ArraySegment<int>(numbers, 0, halfway).ToArray());
            rightArray = MergeSort(new ArraySegment<int>(numbers, halfway, halfway).ToArray());
        }
        else //odd case
        {
            leftArray = MergeSort(new ArraySegment<int>(numbers, 0, halfway).ToArray());
            rightArray = MergeSort(new ArraySegment<int>(numbers, halfway, halfway+1).ToArray());
        }

        return Merge(leftArray, rightArray, numbers);
    }

    //merge two sorted arrays left_array and right_array into an array A
    static int[] Merge(int[] leftArray, int[] rightArray, int[] A)
    {
        //initialize 2 indicies i and j
        int i = 0; int j = 0;

        //merge the elements from A1 and A2 into A
        while (i < leftArray.Length && j < rightArray.Length)
        {
            //if next element in the left array is less than or equal to the next element in the right array, then put the left element into array A
            if (leftArray[i] <= rightArray[j])
            {
                A[i + j] = leftArray[i];
                i++;
            }
            //if next element in the right array is less than the next element in the left array, then put the right element into array A
            else
            {
                A[i + j] = rightArray[j];
                j++;
            }
        }
        
        //while there are elements remaining in the left array, add those elements to A
        while (i < leftArray.Length)
        {
            A[i + j] = leftArray[i];
            i++;
        }

        //while there are elements remaining in the right array, add those elements to A
        while (j < rightArray.Length)
        {
            A[i + j] = rightArray[j];
            j++;
        }
        

        return A;
    }
}