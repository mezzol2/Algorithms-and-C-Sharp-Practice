namespace BinarySearchTreeAVL
{
    class BSTAVL
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
            if (root is not null)
            {
                return root.Height;
            }

            return -1;
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

            node.SetHeight();
            return Balance(node);
        }

        public bool SearchStart(int data)
        {   //returns true is a value exists and false if it does not
            return Search(root,data) != null;
        }

        //returns the Node with the lowest value on this branch
        Node FindMinimum(Node node)
        {
            //go down the left side the branch until node.Left is null
            while (node.Left != null)
            {
                node = node.Left;
            }

            return node;
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

        public void Delete(int data)
        {
            root = Remove(root, data);
        }

        Node? Remove(Node? node, int data)
        {
            if (node == null)
            {
                return null;
            }
            if (data < node.Data)
            {
                node.Left = Remove(node.Left, data);
            }
            else if (data > node.Data)
            {
                node.Right = Remove(node.Right, data);
            }
            //node.Data == data
            else if (node.Left == null)
            {   //if the left side is null, return whatever is on the Right
                node = node.Right;
            }
            else if (node.Right == null)
            {   //if the right side is null, return whatever is on the Left
                node = node.Left;
            }
            else
            {
                //if neither side is null, we will get the lowest value from the right side, and put that in this node
                Node minRight = FindMinimum(node.Right);
                node.Data = minRight.Data;
                //remove the value contined in minRight node from the tree
                node.Right = Remove(node.Right, minRight.Data);
            }

            //if the node is now null, there is nothing to balnce
            if (node is null) return null;

            node.SetHeight();
            return Balance(node);
        }

        Node LeftRotation(Node z)
        {
            Node y = z.Right;
            Node t1 = y.Left;
            y.Left = z;
            z.Right = t1;

            z.SetHeight();
            y.SetHeight();

            return y;
        }

        Node RightRotation(Node z)
        {
            Node y = z.Left;
            Node t2 = y.Right;
            y.Right = z;
            z.Left = t2;

            z.SetHeight();
            y.SetHeight();

            return y;
        }

        int BalanceFactor(Node node)
        {
            if (node is null) return 0;

            if (node.Left is null && node.Right is null)
            {
                return 0;
            }

            if (node.Left is null && node.Right is not null)
            {
                return -1 - node.Right.Height;
            }

            if (node.Left is not null && node.Right is null)
            {
                return node.Left.Height - -1;
            }

            return node.Left.Height - node.Right.Height;
        }

        Node Balance(Node node)
        {
            //tree at this node is right-heavy if less than -1
            if (BalanceFactor(node) < -1)
            {
                //node.Right is left-heavy if greater than 0
                if (BalanceFactor(node.Right) > 0)
                {
                    node.Right = RightRotation(node.Right);
                }
                return LeftRotation(node);
            }
            //tree at this node is left-heavy if greater than 1
            if (BalanceFactor(node) > 1)
            {
                //node.Left is right-heavy if less than 0
                if (BalanceFactor(node.Left) < 0)
                {
                    node.Left = LeftRotation(node.Left);
                }
                return RightRotation(node);
            }
            //neither side is too heavy
            return node;
        }

        private class Node
        {
            public int Data { get; set; }
            public Node? Left { get; set; } = null;
            public Node? Right { get; set; } = null;
            public Node? Parent { get; set; } = null;

            public int Height { get; set; } = 0;

            public Node(int data)
            {
                Data = data;
            }

            public void SetHeight()
            {
                if (Left is null && Right is null)
                {
                    Height = 0;
                    return;
                }

                if (Left is null)
                {
                    Height = 1 + Right.Height;
                    return;
                }

                if (Right is null)
                {
                    Height = 1 + Left.Height;
                    return;
                }

                Height = 1 + Math.Max(Left.Height, Right.Height);
            }
        }
    }   
}