class Program
{
    public static void Main(string[] args)
    {
        int[] num = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 10, 12, 13 };
        int x = 2;

        Console.WriteLine(DirectSearch(num, x));
        Console.WriteLine(BinarySearch(num, x));
    }

    static bool DirectSearch(int[] intArray, int num)
    {
        for (int i = 0; i < intArray.Length; i++)
        {
            if (intArray[i] == num) return true;
        }

        return false;
    }

    static bool BinarySearch(int[] intArray, int num)
    {
        int low = 0;
        int high = intArray.Length - 1;
        while (low <= high)
        {
            int i = (low + high) / 2;

            if (intArray[i] == num) return true;
            else if (intArray[i] < num) low = i + 1;
            else if (intArray[i] > num) high = i - 1;
        }

        return false;
    }
}
