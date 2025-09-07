namespace BinarySearchTree
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create new tree
            BST tree = new BST();
            //Height of an empty tree is -1
            Console.WriteLine(tree.TreeHeight());
        }
    } 
}
