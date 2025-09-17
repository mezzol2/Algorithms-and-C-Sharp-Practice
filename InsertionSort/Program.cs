class Program
{
    public static void Main(string[] args)
    {
        //initialize an array to sort
        int[] numbers = { 2, 3, 6, 29, 109, 8987, 298, 129, 42, -3, 92, 11 };

        //sort the array
        InsertionSort(numbers);

        //print the numbers in the array to check
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.WriteLine(numbers[i]);
        }
    }

    static void InsertionSort(int[] numbers)
    {
        for (int i = 1; i < numbers.Length; i++)
        {
            int j = i;
            while (j > 0 && numbers[j - 1] > numbers[j])
            {
                int temp = numbers[j - 1];
                numbers[j - 1] = numbers[j];
                numbers[j] = temp;
                j--;
            }
        }
    }
}