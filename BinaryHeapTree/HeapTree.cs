namespace BinaryHeapTree
{
    class HeapTree
    {
        Node? root = null;
        public int Size = 0;

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
            public void SwapData(Node otherNode)
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

            //"bubble down" through the tree
            
        }
    }
}