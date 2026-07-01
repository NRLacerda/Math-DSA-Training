using DSA.Algorithms.Graph;
using DSA.DataStructures.Tree;

namespace DSATraining.Tests.Algorithms;

public static class DFSTests
{
    public static IEnumerable<TestCase> All()
    {
        yield return new TestCase("DFS sums all tree nodes", () =>
        {
            var tree = new Tree(
                new TreeNode(3, [
                    new TreeNode(6)
                ])
            );
            var dfs = new DFS();

            dfs.DepthFirstSearch(tree.root);

            Assert.Equal(9, dfs.SumOfTheTree);
        });
    }
}
