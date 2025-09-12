namespace BinaryHeapArray
{
    class Program
    {
        public static void Main(string[] args)
        {
            //initialice the HeapArray
            HeapArray heap = new HeapArray();
            //Insert elements to the heap
            heap.Insert(10); heap.Insert(2); heap.Insert(4); heap.Insert(3); heap.Insert(1);
            //print out all the elements in the heap
            //heap.PrintAll();  //this should print 1, 2, 4, 10, 3
            Console.WriteLine(heap.RemoveMin());  //prints 1
            //heap.PrintAll();
            Console.WriteLine(heap.RemoveMin());  //prints 2
            Console.WriteLine(heap.RemoveMin());  //prints 3
            Console.WriteLine(heap.RemoveMin());  //prints 4
            Console.WriteLine(heap.RemoveMin());  //prints 10
        }
    }
}