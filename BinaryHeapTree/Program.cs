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
            //add 3, 11, 7
            heap.Insert(3); heap.Insert(11); heap.Insert(7);
            //returns 4
            Console.WriteLine(heap.Size);
            //add 1, 50, 2
            heap.Insert(1); heap.Insert(50); heap.Insert(2);
            //returns 7
            Console.WriteLine(heap.Size);
        }
    }
}