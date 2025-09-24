class Program
{
    public static void Main(string[] args)
    {
        //initialize an array to sort
        int[] numbers = { 2, 3, 6, 29, 109, 8987, 298, 129, 42, -3, 92, 11 };

        //sort the array
        QuickSort(numbers, 0, numbers.Length-1);

        //print the numbers in the array to check
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.WriteLine(numbers[i]);
        }
    }

    static int[] QuickSort(int[] numbers, int low, int high)
    {
        if (low >= high)
        {
            return numbers;
        }
        int pivotIndex = Partition(numbers, low, high);
        QuickSort(numbers, low, pivotIndex-1);
        QuickSort(numbers, pivotIndex+1, high);

        return numbers;
    }

    static int Partition(int[] numbers, int low, int high)
    {
        int pivotIndex = ChoosePivot(numbers, low, high);
        Swap(numbers, pivotIndex, high);
        int pivot = numbers[high];
        int left = low;
        int right = high - 1;

        while (left <= right)
        {
            //increment the left pointer by 1 while the value on the left is less than (or equal to) the pivot
            while (left <= right && numbers[left] <= pivot)
            {
                left++;
            }
            //decrement the right pointer by 1 while the value on the right is greater than (or equal to) the pivot
            while (left <= right && pivot <= numbers[right])
            {
                right--;
            }
            //swap two numbers that are not in the correct place
            if (left < right) {
                Swap(numbers, left, right);
            }
        }

        //Put the pivot value in its place in the array
        Swap(numbers, left, high);

        //return the index of the pivot
        return left;
    }

    //Choose the pivot by selecing the median value from the fist, middle, and last indicies
    static int ChoosePivot(int[] numbers, int low, int high)
    {
        //assume that the lowest index is the middle value
        int pivot = low;
        int mid = (high + low) / 2;

        //check is the middle value would be better
        if ((numbers[low] < numbers[mid] && numbers[mid] <= numbers[high]) ||
            (numbers[low] > numbers[mid] && numbers[mid] >= numbers[high])
        )
        {
            pivot = mid;
        }

        //check is the high value would be better
        if ((numbers[low] < numbers[high] && numbers[high] < numbers[mid]) ||
            (numbers[low] > numbers[high] && numbers[high] > numbers[mid])
        )
        {
            pivot = high;
        }

        return pivot;
    }

    static void Swap(int[] A, int i, int j)
    {
        int temp = A[i];
        A[i] = A[j];
        A[j] = temp;
    }
}