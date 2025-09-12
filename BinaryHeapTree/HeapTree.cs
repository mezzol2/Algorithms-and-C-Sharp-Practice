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
                // 
                //
            }

            //increase the Size of the tree
            Size++;
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
            void BubbleUp()
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



            public Node Find(String path)
            {
                Node? res = null;
                //if the path is an empty string, this is the needed node
                if (path == "")
                {
                    res = this;
                }

                //if the first character is a 0, go to the left
                if (path[0] == '0')
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