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

        //Create a new Node in the last position
        Node AddLast(int x)
        {
            //Convert our size into a bitstring
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
}