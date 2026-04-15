using DSA.DataStructures.Tree;
using System.Collections.Generic;

namespace DSA.Algorithms.Graph
{
    public class BFS
    {
        public List<TreeNode> ShortestPath(TreeNode root, TreeNode target)
        {
            if (root == null || target == null) return new List<TreeNode>();

            var queue = new Queue<(TreeNode node, List<TreeNode> path)>();
            queue.Enqueue((root, new List<TreeNode> { root }));

            while (queue.Count > 0)
            {
                var (current, path) = queue.Dequeue();

                if (current == target)
                    return path;

                foreach (var child in current.children)
                {
                    var newPath = new List<TreeNode>(path) { child };
                    queue.Enqueue((child, newPath));
                }
            }

            return new List<TreeNode>();
        }
    }
}