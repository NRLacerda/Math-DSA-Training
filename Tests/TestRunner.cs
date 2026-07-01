namespace DSATraining.Tests;

public static class TestRunner
{
    public static void Run(IEnumerable<TestCase> tests)
    {
        PrintBanner();

        int passed = 0;
        int failed = 0;

        foreach (TestCase test in tests)
        {
            Console.Write($"  -> {test.Name,-55}");

            try
            {
                test.Run();
                passed++;
                PrintStatus("PASS", ConsoleColor.Green);
            }
            catch (TestFailureException ex)
            {
                failed++;
                PrintStatus("FAIL", ConsoleColor.Red);
                PrintDetail(ex.Message);
            }
            catch (Exception ex)
            {
                failed++;
                PrintStatus("ERROR", ConsoleColor.Red);
                PrintDetail($"{ex.GetType().Name}: {ex.Message}");
            }
        }

        PrintSummary(passed, failed);
    }

    private static void PrintBanner()
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine();
        Console.WriteLine("  DSA Test Runner");
        Console.WriteLine("  " + new string('-', 72));
        Console.ResetColor();
    }

    private static void PrintStatus(string status, ConsoleColor color)
    {
        Console.ForegroundColor = color;
        Console.WriteLine(status);
        Console.ResetColor();
    }

    private static void PrintDetail(string message)
    {
        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.WriteLine($"     {message}");
        Console.ResetColor();
    }

    private static void PrintSummary(int passed, int failed)
    {
        int total = passed + failed;

        Console.WriteLine();
        Console.Write("  Results: ");

        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write($"{passed} passed");
        Console.ResetColor();

        Console.Write(" / ");

        Console.ForegroundColor = failed > 0 ? ConsoleColor.Red : ConsoleColor.DarkGray;
        Console.Write($"{failed} failed");
        Console.ResetColor();

        Console.WriteLine($" / {total} total");
        Console.WriteLine();
    }
}
