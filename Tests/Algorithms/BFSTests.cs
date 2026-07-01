using DSA.Algorithms.Graph;
using DSA.DataStructures.Tree;

namespace DSATraining.Tests.Algorithms;

public static class BFSTests
{
    public static IEnumerable<TestCase> All()
    {
        yield return new TestCase("BFS finds the shortest path to a target node", () =>
        {
            var target = new TreeNode(7);
            var node4 = new TreeNode(4, [target]);
            var node5 = new TreeNode(5);
            var node6 = new TreeNode(6);
            var node2 = new TreeNode(2, [node4, node5]);
            var node3 = new TreeNode(3, [node6]);
            var root = new TreeNode(1, [node2, node3]);
            var bfs = new BFS();

            List<TreeNode> path = bfs.ShortestPath(root, target);

            Assert.SequenceEqual([1, 2, 4, 7], path.Select(node => node.val));
        });

        yield return new TestCase("BFS returns an empty path when target is missing", () =>
        {
            var root = new TreeNode(1, [
                new TreeNode(2),
                new TreeNode(3)
            ]);
            var target = new TreeNode(99);
            var bfs = new BFS();

            List<TreeNode> path = bfs.ShortestPath(root, target);

            Assert.Equal(0, path.Count);
        });
    }
}
