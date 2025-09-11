namespace BinaryHeapTree
{
    class HeapTree
    {
        Node? root = null;
        Node? last = null;

        public void Insert(int data)
        {
            //if the tree is empty, create a new Node and set it as the root
            if (root == null)
            {
                root = new Node(null, data);
                last = root;
                return;
            }
        }

        private class Node
        {
            public Node? Parent { get; set; } = null;
            public int Data { get; set; }
            public Node? Left { get; set; } = null;
            public Node? Right { get; set; } = null;

            public Node(Node? parent, int data)
            {
                Parent = parent;
                Data = data;
            }
        }
    }
}