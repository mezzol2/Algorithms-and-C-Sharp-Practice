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
            return 1 + Math.Max(Height(node.Left), Height(node.Right));
        }

        public void InsertStart(int data)
        {
            //initialize insertion at the root
            root = Insert(root, data);
        }

        Node Insert(Node? node, int data)
        {
            if (node == null)
            {   //is there is no Node, make one
                node = new Node(data);
            }
            else if (data < node.Data)
            {   //if the data is less than the data in the node, Insert to the Left
                node.Left = Insert(node.Left, data);
            }
            else if (node.Data < data)
            {   //if the data is greater than the data in the node, Insert to the Right
                node.Right = Insert(node.Right, data);
            }

            //return either this node
            return node;
        }

        public bool SearchStart(int data)
        {   //returns true is a value exists and false if it does not
            return Search(root,data) != null;
        }

        Node? Search(Node? node, int data)
        {
            Node? res = null;
            if (node == null)
            {
                //return null
            }
            else if (node.Data == data)
            {   //if the data matches, return this node
                res = node;
            }
            else if (data < node.Data)
            {   //if the data is less than the node, Search the Left side
                res = Search(node.Left, data);
            }
            else if (data > node.Data)
            {   //if the data is greater than the node, Search the Right side
                res = Search(node.Right, data);
            }

            return res;
        }

        private class Node
        {
            public int Data { get; set; }
            public Node? Left { get; set; } = null;
            public Node? Right { get; set; } = null;
            public Node? Parent { get; set; } = null;

            public Node(int data)
            {
                Data = data;
            }
        }
    }   
}