using DSA.DataStructures.Tree;
using DSA.Algorithms.Graph;
using DSA.Math.Sigma;

// ─────────────────────────────────────────────
//   DSA TEST SUITE  |  v1.0.0
// ─────────────────────────────────────────────

static void PrintHeader(string title, string icon = "▶")
{
    string border = new string('─', 44);
    Console.ForegroundColor = ConsoleColor.Cyan;
    Console.WriteLine($"\n┌{border}┐");
    Console.WriteLine($"│  {icon}  {title,-39}│");
    Console.WriteLine($"└{border}┘");
    Console.ResetColor();
}

static void PrintResult(string label, string value, bool success = true)
{
    Console.Write($"  {"→",2}  {label,-28}");
    Console.ForegroundColor = success ? ConsoleColor.Green : ConsoleColor.Red;
    Console.WriteLine(value);
    Console.ResetColor();
}

static void PrintPass(string message)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine($"  ✔  {message}");
    Console.ResetColor();
}

static void PrintFail(string message)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine($"  ✘  {message}");
    Console.ResetColor();
}

// ── Banner ────────────────────────────────────
Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine(@"
  ██████╗ ███████╗ █████╗     ████████╗███████╗███████╗████████╗███████╗
  ██╔══██╗██╔════╝██╔══██╗       ██╔══╝██╔════╝██╔════╝╚══██╔══╝██╔════╝
  ██║  ██║███████╗███████║       ██║   █████╗  ███████╗   ██║   ███████╗
  ██║  ██║╚════██║██╔══██║       ██║   ██╔══╝  ╚════██║   ██║   ╚════██║
  ██████╔╝███████║██║  ██║       ██║   ███████╗███████║   ██║   ███████║
  ╚═════╝ ╚══════╝╚═╝  ╚═╝       ╚═╝   ╚══════╝╚══════╝   ╚═╝   ╚══════╝
");
Console.ResetColor();
Console.ForegroundColor = ConsoleColor.DarkGray;
Console.WriteLine("  Data Structures & Algorithms — Automated Test Runner\n");
Console.ResetColor();

int passed = 0;
int failed = 0;

// ── Test 1: DFS Tree Sum ──────────────────────
PrintHeader("DEPTH-FIRST SEARCH  |  Tree Sum", "🌳");

Tree tree = new Tree(
    new TreeNode(3, new TreeNode[] {
        new TreeNode(6)
    })
);

DFS dfs = new DFS();
dfs.DepthFirstSearch(tree.root);

int expectedSum = 9;
bool sumPass = dfs.SumOfTheTree == expectedSum;

PrintResult("Root value", $"{tree.root.val}");
PrintResult("DFS Sum", $"{dfs.SumOfTheTree}  (expected: {expectedSum})");

if (sumPass) { PrintPass("DFS Sum matches expected value."); passed++; }
else { PrintFail($"DFS Sum mismatch! Got {dfs.SumOfTheTree}, expected {expectedSum}."); failed++; }

// ── Test 2: Sigma ─────────────────────────────
PrintHeader("MATH  |  Sigma (Triangular Sum)", "🧮");

Maths math = new Maths();
int sigmaInput = 3;
int sigmaExpected = 6;          // 1 + 2 + 3
int sigmaResult = math.Sigma(sigmaInput);
bool sigmaPass = sigmaResult == sigmaExpected;

PrintResult($"Σ({sigmaInput})", $"{sigmaResult}  (expected: {sigmaExpected})");

if (sigmaPass) { PrintPass($"Sigma({sigmaInput}) returned correct value."); passed++; }
else { PrintFail($"Sigma mismatch! Got {sigmaResult}, expected {sigmaExpected}."); failed++; }

// ── Test 3: BFS Shortest Path ─────────────────
PrintHeader("BREADTH-FIRST SEARCH  |  Shortest Path", "🗺");

var target = new TreeNode(7);
var node4 = new TreeNode(4, new[] { target });
var node5 = new TreeNode(5);
var node6 = new TreeNode(6);
var node2 = new TreeNode(2, new[] { node4, node5 });
var node3 = new TreeNode(3, new[] { node6 });
var root = new TreeNode(1, new[] { node2, node3 });

var bfs = new BFS();
var path = bfs.ShortestPath(root, target);

bool pathFound = path.Count > 0;
var expectedPath = new[] { 1, 2, 4, 7 };
bool pathCorrect = pathFound
    && path.Count == expectedPath.Length
    && path.Select((n, i) => n.val == expectedPath[i]).All(x => x);

// Print path inline
Console.Write($"\n  → Path to node {target.val}:  ");
if (pathFound)
{
    Console.ForegroundColor = ConsoleColor.White;
    Console.Write(string.Join(" → ", path.Select(n => n.val)));
    Console.ResetColor();
    Console.WriteLine();
}
else
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("No path found.");
    Console.ResetColor();
}

if (pathCorrect) { PrintPass("Shortest path is correct."); passed++; }
else { PrintFail("Shortest path is incorrect or not found."); failed++; }

// ── Summary ───────────────────────────────────
Console.WriteLine();
Console.ForegroundColor = ConsoleColor.DarkGray;
Console.WriteLine("  " + new string('─', 44));
Console.ResetColor();

int total = passed + failed;
Console.Write($"\n  Results: ");
Console.ForegroundColor = ConsoleColor.Green;
Console.Write($"{passed} passed");
Console.ResetColor();
Console.Write("  /  ");
Console.ForegroundColor = failed > 0 ? ConsoleColor.Red : ConsoleColor.DarkGray;
Console.Write($"{failed} failed");
Console.ResetColor();
Console.WriteLine($"  /  {total} total\n");

if (failed == 0)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("  All tests passed! 🎉");
}
else
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine($"  {failed} test(s) failed. Review output above.");
}
Console.ResetColor();

// ── Owl ───────────────────────────────────────
Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine(@"
                         ____    .-.
                     .-""`    `"",( __\_
      .-==:;-._    .'         .-.     `'.
    .'      `""-:'-/          (  \} -=a  .)
   /            \/       \,== `-  __..-'`
'-'              |       |   |  .'\ `;
                  \    _/---'\ (   `""`
                 /.`._ )      \ `;
                 \`-/.'        `""`
                  `""\`-.
                NRLacerda  `""`
");
// ASCII art is simply stunning
Console.ResetColor();