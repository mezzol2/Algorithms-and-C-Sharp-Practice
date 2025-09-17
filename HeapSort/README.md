This program implements the Heap Sort method in order to sort an array.

The algorithm starts by ordering the array as a max-heap.  Then the algorithm swaps the root of the heap (first element in the array) with the last element in the heap.  The last element is removed from the heap, and the remaining elements are heapified.  This continues until all the elements are swapped.  The resulting array is sorted in ascending order.

The time complexity of this algorithm is linearithmic or O(n logn).