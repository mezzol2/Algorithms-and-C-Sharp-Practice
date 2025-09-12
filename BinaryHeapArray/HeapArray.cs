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
        public void Insert(int x)
        {
            //add the new element to the end of the list
            list.Add(x);
            //get the index of the item just added, ie, the last item in the list
            int i = list.Count - 1;

            //now, we need to move this element to the correst position
            //while we are not at the beginning of the list AND the parent index is greater than the child
            while (0 < i && list[i] < list[ParentOf(i)])
            {
                //swap the values of the elements at the two indexes
                Swap(i, ParentOf(i));
                //now we need to check the parent since it has been modified
                i = ParentOf(i);
            }
        }

        //remove the lowest value integer
        public int RemoveMin()
        {
            //store the lowest value interger
            int x = list[0];
            //move the last value in the list to the first position
            list[0] = list[list.Count - 1];
            list.RemoveAt(list.Count - 1);

            int i = 0;
            //while the left child is not the last index in the list
            while (LeftOf(i) < list.Count - 1)
            {
                //store the index of the left child
                int j = LeftOf(i);

                //we want to compare the parent against the lesser of left and right children
                //if the right child is not the last index in the list and the value on the right is less than the value on the left
                if (RightOf(i) < list.Count - 1 && list[RightOf(i)] < list[j])
                {
                    //change j to the right child
                    j = RightOf(i);
                }
                //if the parent i is less than or equal to the child j, return x
                if (list[i] <= list[j])
                {
                    return x;
                }
                //otherwise, swap the parent i and child j and continue from the child
                Swap(i, j);
                i = j;
            }

            return x;
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
        int RightOf(int i)
        {
            return 2 * (i + 2);
        }

        //this method swaps the elements in the list at indexes i and j
        void Swap(int i, int j)
        {
            int iValue = list[i];
            list[i] = list[j];
            list[j] = iValue;
        }

    } 
}