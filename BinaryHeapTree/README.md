This program implements a priority queue via a binary heap tree.  For simplcity, this priority queue implementation can only contain integers.

Constructor
    HeapTree():  Initializes a new instance of the HeapTree class.

Methods
    Insert(int x): Adds a new integer x to the HeapTree in O(log n) time.

    CheckMin():  Returns the lowest value integer in the HeapTree in O(1) time.
    
    RemoveMin():  Removes and returns the lowest value integer in the HeapTree in O(log n) time.

    Size:   Returns the number of integers contined in the HeapTree in O(1) time.