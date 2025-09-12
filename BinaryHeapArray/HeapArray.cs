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

        //if our heap was a tree, this returns the parent of a given index
        int ParentOf(int i)
        {
            return (i - 1) / 2;
        }

        //returns what would be the left child node in a tree
        int LeftOf(int i)
        {
            return 2 * (i + 1);
        }
        
        //returns what would be the right child node in a tree
        int RightOf(int i) {
            return 2 * (i + 2);
        }

    } 
}