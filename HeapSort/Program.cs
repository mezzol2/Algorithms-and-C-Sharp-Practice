class Program
{
    public static void Main(string[] args)
    {
        //initialize an array to sort
        int[] numbers = { 2, 3, 6, 29, 109, 8987, 298, 129, 42, -3, 92, 11 };

        //sort the array
        HeapSort(numbers);

        //print the numbers in the array to check
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.WriteLine(numbers[i]);
        }
    }

    //This method sorts an array by first turning the array into a max-heap, and then "bubbling down" elements into the correct position
    static void HeapSort(int[] numbers)
    {
        //Convert array to a Max Heap
        BuildMaxHeap(numbers);
        //Starting from the end, swap the highest value with value at index i, and BubbleDown
        for (int i = numbers.Length - 1; i > 0; i--)
        {
            Swap(numbers, 0, i);
            BubbleDown(numbers, 0, i);
        }
    }

    //this method makes a heap (implemented an as array) slighlty more sorted
    static void BubbleDown(int[] numbers, int i, int n)
    {
        //Given an index i
        int largest = i;
        int left = 2 * i + 1;
        int right = 2 * i + 2;

        //Check if the left "node" is the largest
        //We have to check is the left index is in range of the array
        if (left < n && numbers[largest] < numbers[left])
        {
            largest = left;
        }

        //Check if the right "node" is the largest
        //We have to check is the right index is in range of the array
        if (right < n && numbers[largest] < numbers[right])
        {
            largest = right;
        }

        //if index i does not contain the largest element, make i contain the largest element by swapping the elements at i and largest
        if (i != largest)
        {
            Swap(numbers, i, largest);
            BubbleDown(numbers, largest, n);
        }
    }

    //Swaps the elements at two indicies within an array
    static void Swap(int[] numbers, int i, int j)
    {
        int temp = numbers[i];
        numbers[i] = numbers[j];
        numbers[j] = temp;
    }

    //Builds a max-heap given an array
    static void BuildMaxHeap(int[] numbers) {
        for (int i = numbers.Length/2; i >= 0; i--)
        {
            BubbleDown(numbers, i, numbers.Length);
        }
    }
}