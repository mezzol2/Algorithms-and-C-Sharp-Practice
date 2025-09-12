namespace BinaryHeapArray
{
    class HeapArray
    {
        //initialize our underlying list
        List<int> list = new List<int>();

        //print all the elements in the list to the terminal
        //This is for testing
        public void PrintAll()
        {
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }
        }

        //add elements to the end of our list
        public void Add(int x)
        {

            list.Add(x);

        }

    } 
}