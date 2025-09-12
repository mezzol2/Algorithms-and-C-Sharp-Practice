namespace BinaryHeapTree
{
    class Program
    {
        public static void Main(string[] args)
        {
            //initialize the heap
            HeapTree heap = new HeapTree();
            //add 10
            heap.Insert(10);
            //returns 1
            Console.WriteLine(heap.Size);
            //add 3
            //heap.Insert(3);
        }
    }
}