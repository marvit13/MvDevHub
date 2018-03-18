using System.Collections.Generic;

namespace MvPyramid
{
    class Node
    {
        public int Value { get; set; }
        public Node Parent { get; set; }
        public Node LeftSibling { get; set; }
        public Node RightSibling { get; set; }
        public List<Node> Children = new List<Node>();
        public bool IsEven { get { return Value % 2 == 0; } }
        public Node LeftmostSibling { get { return this.LeftSibling == null ? this : this.LeftSibling.LeftmostSibling; } }

        public void AddAsChild()
        {
            if (Parent != null && !Parent.Children.Contains(this))
            {
                Parent.Children.Add(this);
            }
            if (LeftSibling != null && !LeftSibling.Parent.Children.Contains(this))
            {
                LeftSibling.Parent.Children.Add(this);
            }
        }
    }
}
