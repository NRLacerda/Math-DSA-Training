namespace DSA.DataStructures.Tree
{
    public class Tree
    {
        public TreeNode root;

        public Tree(TreeNode root)
        {
            this.root = root;
        }
    }

    public class TreeNode
    {
        public int val;
        public TreeNode[] children = { };

        public TreeNode(int val = 0, TreeNode[]? children = null)
        {
            this.val = val;
            this.children = children ?? new TreeNode[0];
        }
    }
}