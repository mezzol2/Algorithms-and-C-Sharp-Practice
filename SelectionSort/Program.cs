class Program
{
    public static void Main(string[] args)
    {
        //initialize an array to sort
        int[] numbers = { 2, 3, 6, 29, 109, 8987, 298, 129, 42, -3, 92, 11 };

        //sort the array
        SelectionSort(numbers);

        //print the numbers in the array to check
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.WriteLine(numbers[i]);
        }
    }

    static void SelectionSort(int[] numbers)
    {
        for (int i = 0; i < numbers.Length; i++)
        {
            int lowest = i;
            for (int j = i + 1; j < numbers.Length; j++)
            {
                if (numbers[j] < numbers[lowest])
                {
                    lowest = j;
                }
            }
            if (i != lowest)
            {
                int temp = numbers[i];
                numbers[i] = numbers[lowest];
                numbers[lowest] = temp;
            }
        }
    }
}
