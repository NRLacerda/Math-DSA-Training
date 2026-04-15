using DSA.DataStructures.Tree;

namespace DSA.Algorithms.Graph
{
    public class DFS
    {
        public int SumOfTheTree { get; private set; }

        public void DepthFirstSearch(TreeNode node)
        {
            if (node == null) return;

            SumOfTheTree += node.val;

            foreach (var child in node.children)
            {
                DepthFirstSearch(child);
            }
        }
    }
}