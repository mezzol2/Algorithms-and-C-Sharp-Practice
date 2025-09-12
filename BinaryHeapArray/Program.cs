namespace BinaryHeapArray
{
    class Program
    {
        public static void Main(string[] args)
        {
            //initialice the HeapArray
            HeapArray heap = new HeapArray();
            //add elements to the heap
            heap.Add(10); heap.Add(2); heap.Add(4); heap.Add(3); heap.Add(1);
            //print out all the elements in the heap
            heap.PrintAll();
        }
    }
}