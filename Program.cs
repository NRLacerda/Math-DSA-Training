// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Solution sol = new Solution();

sol.TwoSum([2, 7, 11, 15], 9);

Console.WriteLine("============================================");
Console.WriteLine("==============TREES EXERCISES===============");
Console.WriteLine("============================================");

Tree tree = new Tree(
    new TreeNode(3, new TreeNode[] {
        new TreeNode(6)
    })
);

DFS dfs = new DFS();
dfs.DepthFirstSearch(tree.root);

Console.WriteLine("The sum of the tree is: " + dfs.SumOfTheTree);

Console.WriteLine("============================================");
Console.WriteLine("==============MATH EXERCISES===============");
Console.WriteLine("============================================");

Maths math = new Maths();
int sigmaExample = 3;
Console.WriteLine("The sigma of " + sigmaExample + " is " + math.Sigma(sigmaExample));
List<int> res = new List<int>();
res.Add(2);
int[] array = res.ToArray();
string s = string.Empty;

s += "abc";

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