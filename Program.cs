// See https://aka.ms/new-console-template for more information
Console.WriteLine("🚀 Starting Tests...\n");

Solution sol = new Solution();

Console.WriteLine("=== 🧮 Two Sum Test ===");
var twoSumResult = sol.TwoSum([2, 7, 11, 15], 9);
Console.WriteLine($"Input: [2,7,11,15], Target: 9");
Console.WriteLine($"Output: [{twoSumResult[0]}, {twoSumResult[1]}]\n");


Console.WriteLine("============================================");
Console.WriteLine("🌳 TREES EXERCISES");
Console.WriteLine("============================================");

Tree tree = new Tree(
    new TreeNode(3, new TreeNode[] {
        new TreeNode(6)
    })
);

DFS dfs = new DFS();
dfs.DepthFirstSearch(tree.root);

Console.WriteLine($"Tree Root: {tree.root.val}");
Console.WriteLine($"Sum of the tree: {dfs.SumOfTheTree}\n");


Console.WriteLine("============================================");
Console.WriteLine("🧮 MATH EXERCISES");
Console.WriteLine("============================================");

Maths math = new Maths();
int sigmaExample = 3;

Console.WriteLine($"Sigma({sigmaExample}) = {math.Sigma(sigmaExample)}\n");


Console.WriteLine("============================================");
Console.WriteLine("🌐 BFS SHORTEST PATH TEST");
Console.WriteLine("============================================");

// Building tree
var target = new TreeNode(7);
var node4 = new TreeNode(4, new[] { target });
var node5 = new TreeNode(5);
var node6 = new TreeNode(6);

var node2 = new TreeNode(2, new[] { node4, node5 });
var node3 = new TreeNode(3, new[] { node6 });

var root = new TreeNode(1, new[] { node2, node3 });

var bfs = new BFS();
var path = bfs.ShortestPath(root, target);

// Pretty print path
Console.Write($"Path from root to target {target.val}: ");

if (path.Count == 0)
{
    Console.WriteLine("No path found ❌");
}
else
{
    for (int i = 0; i < path.Count; i++)
    {
        Console.Write(path[i].val);
        if (i < path.Count - 1)
            Console.Write(" -> ");
    }
    Console.WriteLine(" ✅");
}

Console.WriteLine("\n Tests Finished!");

// used chatgpt to generate this test boilerplate bullshit

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

public class Maths
{
    public int Sigma(int n)
    {
        int sum = 0;

        while (n != 0)
        {
            sum += n;
            n--;
        }

        return sum;
    }
}

public class BFS
{
    public void BreadthFirstSearch(TreeNode root)
    {
        HashSet<TreeNode> visited = new HashSet<TreeNode>();
        Queue<TreeNode> q = new Queue<TreeNode>();

        q.Enqueue(root);

        while(q.Count > 0)
        {
            TreeNode cur = q.Dequeue();

            // do some proccess here, like calculating the shortest path on unweighted graphs/trees, the 
            // shortest path from Node A to Target is always the first time Target is hit 

            foreach(TreeNode child in cur.children)
            {
                if (!visited.Contains(child))
                {
                    visited.Add(child);
                    q.Enqueue(child);
                }
            }
        }
    }

    public List<TreeNode> ShortestPath(TreeNode root, TreeNode target)
    {
        HashSet<TreeNode> visited = new HashSet<TreeNode>();
        Queue<TreeNode> q = new Queue<TreeNode>();
        Dictionary<TreeNode, TreeNode> parent = new Dictionary<TreeNode, TreeNode>();

        q.Enqueue(root);
        parent[root] = null;
        visited.Add(root);

        while (q.Count > 0)
        {
            TreeNode cur = q.Dequeue();

            if(cur == target)
            {
                return BuildPath(parent, target);
            }

            foreach (TreeNode child in cur.children)
            {
                if (!visited.Contains(child))
                {
                    visited.Add(child);
                    parent[child] = cur;
                    q.Enqueue(child);
                }
            }
        }

        return new List<TreeNode>();
    }

    private List<TreeNode> BuildPath(Dictionary<TreeNode, TreeNode> parent, TreeNode target)
    {
        List<TreeNode> path = new List<TreeNode>();
        TreeNode cur = target;

        while(cur is not null)
        {
            path.Add(cur);
            cur = parent[cur];
        }
        path.Reverse();
        return path;
    }
}
public class DFS
{
    public int SumOfTheTree = 0;

    public void DepthFirstSearch(TreeNode node)
    {
        if (node is null) return;

        SumOfTheTree += node.val;

        foreach (var child in node.children)
        {
            DepthFirstSearch(child);
        }
    }
}

public class ListNode
{
    public int val;
    public ListNode next;
    public ListNode(int val = 0, ListNode next = null)
    {
        this.val = val;
        this.next = next;
    }
}

public class Solution
{
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
    {
        return l1;
    }



    public int[] TwoSum(int[] nums, int target)
    {
        Dictionary<int, int> seen = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++)
        {
            int need = target - nums[i];

            if (seen.ContainsKey(need))
            {
                return [nums[i], seen[need]];
            }
            seen[nums[i]] = i;
        }

        return [0, 0];
    }
}


/*



Arrays:

find duplicates
two sum
max subarray
rotate array

Strings:
reverse string
find substring
character frequency
palindrome
longest substring without repeating characters

Hashtables and Dictionaries:
fast lookup
frequency counting
duplicate detection

Stack
valid parentheses
evaluate expressions
next greater element

Queue:
tree traversal
shortest path
level order traversal

Linked Lists:
reverse list
detect cycle
remove node

Trees:
DFS
BFS
tree height
balanced tree

Recursion:
permutations
backtracking
tree traversal




*/