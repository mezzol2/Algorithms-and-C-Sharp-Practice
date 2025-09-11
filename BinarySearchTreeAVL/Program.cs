namespace BinarySearchTreeAVL
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create new tree
            BSTAVL tree = new BSTAVL();
            //Height of an empty tree is -1
            Console.WriteLine(tree.TreeHeight());
            //Insert(50)
            tree.InsertStart(50);
            //Height should be 0
            Console.WriteLine(tree.TreeHeight());
            //Insert 30 and 80
            tree.InsertStart(30); tree.InsertStart(80);
            //Height should be 1
            Console.WriteLine(tree.TreeHeight());
            //Insert 60
            tree.InsertStart(60);
            //Height should be 2
            Console.WriteLine(tree.TreeHeight());
            //Search(60) should return True
            Console.WriteLine(tree.SearchStart(60));
            //Search(34) should return false
            Console.WriteLine(tree.SearchStart(34));
            //Delete(50) will delete the root
            tree.Delete(50);
            //Search(50) should return false
            Console.WriteLine(tree.SearchStart(50));
            //TreeHeight() should return 1
            Console.WriteLine(tree.TreeHeight());
        }
    } 
}
