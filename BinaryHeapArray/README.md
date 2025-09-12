This program implements a priority queue.  Implementaion is done using a list that simulates a binary heap tree.  For simplcity, this priority queue implementation can only contain integers.

Constructor
    HeapArray():  Initializes a new instance of the HeapArray class.

Methods
    Insert(int x): Adds a new integer x to the HeapArray in O(log n) time.

    RemoveMin():  Removes and returns the lowest value integer in the HeapArray in O(log n) time.

    PrintAll():  Prints every integer in the underlying list in O(n) time.  This method is intended for testing.