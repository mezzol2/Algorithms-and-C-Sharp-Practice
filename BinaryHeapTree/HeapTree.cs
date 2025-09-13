namespace BinaryHeapTree
{
    class HeapTree
    {
        Node? root = null;
        public int Size = 0;

        //Insert a new value into the tree
        public void Insert(int data)
        {
            //if the tree is empty, create a root node
            if (root is null)
            {
                root = new Node(null, data);
            }
            else
            {
                Node last = AddLast(data);
                last.BubbleUp();
            }

            //increase the Size of the tree
            Size++;
        }


        //this method checks the smallest value from the tree
        public int CheckMin()
        {
            if (root == null)
            {
                throw new EmptyTreeException("Tree is empty.");
            }

            return root.Data;
        }

        //this method removes and return the smallest value from the tree
        public int RemoveMin()
        {
            int min = CheckMin();

            //check if the root is the only node in the tree
            if (Size == 1)
            {
                //remove the root from the tree and return min
                root = null;
                Size = 0;
                return min;
            }

            //get the value from the last node
            root.Data = RemoveLast();

            //bubble down the value until it is in the correct place
            root.BubbleDown();

            //decrease the Size of the tree and return the minimum value
            Size--;
            return min;
        }

        //get the value from the last node and remove that node from the tree
        int RemoveLast()
        {
            //Convert our size into a bitstring
            String path = Convert.ToString(Size, 2);
            //Find the last node
            Node last = root.Find(path.Substring(1));
            //remove the last node form the tree
            //if the last bit of the path was 0, last is a left child
            if (path[^1] == '0')
            {
                last.Parent.Left = null;
            }
            //if the last bit of the path was 1, last is a right child
            if (path[^1] == '1')
            {
                last.Parent.Right = null;
            }
            //return the value from the last node
            return last.Data;
        }

        //Create a new Node in the last position
        Node AddLast(int x)
        {
            //Convert our size with the new last node into a bitstring
            String path = Convert.ToString(Size + 1, 2);
            //Get the length of the bistring
            int length = path.Length;
            //Find the path to the last node's parent
            Node lastParent = root.Find(path.Substring(1, length - 2));
            Node last = new Node(lastParent, x);

            //Check the last character in the String to determine wherther the node Last node will be placed to the Left or the Right
            if (path[^1] == '0')
            {
                lastParent.Left = last;
            }

            if (path[^1] == '1')
            {
                lastParent.Right = last;
            }

            return last;
        }

        private class Node
        {
            public int Data { get; set; }
            public Node? Parent { get; set; }
            public Node? Left { get; set; } = null;
            public Node? Right { get; set; } = null;


            public Node(Node? parent, int data)
            {
                Parent = parent;
                Data = data;
            }

            //Swap the data between 2 nodes
            void SwapData(Node otherNode)
            {
                int temp = Data;
                Data = otherNode.Data;
                otherNode.Data = temp;
            }

            //"bubble up" through the tree
            public void BubbleUp()
            {
                if (Parent is null)
                {
                    return;
                }

                //is the child's Data is less the Parent's Data, swap the data within them, and repeat on the Parent 
                if (Data < Parent.Data)
                {
                    this.SwapData(Parent);
                    Parent.BubbleUp();
                }
            }

            //"bubble down" a value through the tree
            public void BubbleDown()
            {
                //initialize the child as the Right
                Node child = Right;
                //check if we should actually check on the Left
                if (child is null || Left.Data <= Right.Data)
                {
                    child = Left;
                }

                if (child is not null && child.Data < Data)
                {
                    this.SwapData(child);
                    child.BubbleDown();
                }
            }

            //Finds a node given the path
            public Node Find(String path)
            {
                Node? res = null;
                //if the path is an empty string or the path only contains 1 character, this is the needed node
                if (path.Equals(""))
                {
                    res = this;
                }
                //if the first character is a 0, go to the left
                else if (path[0] == '0')
                {
                    path = path.Substring(1);
                    res = Left.Find(path);
                }
                //if the first character is 1, go to the right
                else if (path[0] == '1')
                {
                    path = path.Substring(1);
                    res = Right.Find(path);
                }

                return res;
            }
        }
    }

    class EmptyTreeException : Exception
    {
        public EmptyTreeException(String message)
            : base(message)
        {
        }
    }
}