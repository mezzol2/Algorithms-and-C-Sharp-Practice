namespace BinarySearchTree
{
    class BST
    {
        private Node? root = null;

        int FindNodeDepth(Node? node)
        {
            if (node == null)
                return -1;

            return 1 + FindNodeDepth(node.Parent);
        }

        public int TreeHeight()
        {
            return Height(root);
        }

        int Height(Node? node)
        {
            if (node == null)
            {
                return -1;
            }
            return 1 + Math.Max(Height(node.Left),Height(node.Right));
        }

        private class Node
        {
            public int Data { get; set; }
            public Node? Left { get; set; } = null;
            public Node? Right { get; set; } = null;
            public Node? Parent { get; set; } = null;


        }
    }   
}