using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvPyramid
{
    class Tree
    {
        private Node _root;
        private Stack<int> _stack;
        private List<List<int>> _resultList;

        public Tree(List<List<int>> inputValues)
        {
            //load values in the binary tree format to be traversed for the best path
            LoadBinaryTree(inputValues);
        }

        public List<List<int>> GetEvenOddValues()
        {
            _stack = new Stack<int>();
            _resultList = new List<List<int>>();
            TraverseEvenOddNodes(_root);

            //order by max sum first
            _resultList = _resultList.OrderByDescending(v => v.Sum()).ToList();

            return _resultList;
        }
        private void LoadBinaryTree(List<List<int>> inputValues)
        {
            Node lastNode = _root;
            foreach (var group in inputValues)
            {
                for (var x = 0; x < group.Count; x++)
                {
                    var node = new Node { Value = group[x] };

                    // handle first value
                    if (lastNode == null)
                    {
                        _root = node;
                    }
                    else
                    {
                        //handle moving to new level/group
                        if (x == 0)
                        {
                            //get leftmost parent
                            node.Parent = lastNode.LeftmostSibling;
                        }
                        else
                        {
                            node.LeftSibling = lastNode;
                            lastNode.RightSibling = node;
                            node.Parent = lastNode.Parent.RightSibling != null ? lastNode.Parent.RightSibling : null;
                        }

                        //add children to parent nodes
                        node.AddAsChild();
                    }
                    lastNode = node;
                }
            }
        }

        private void TraverseEvenOddNodes(Node node)
        {
            _stack.Push(node.Value);
            if (node.Children.Count == 0)
            {
                //if bottom of pyramid reached add to valid paths
                _resultList.Add(_stack.Reverse().ToList());
            }
            else
            {
                node.Children.Where(c => node.IsEven != c.IsEven).ToList().ForEach(c => TraverseEvenOddNodes(c));
            }
            _stack.Pop();
        }
    }
}
