namespace DSATraining.Tests;

public static class Assert
{
    public static void Equal<T>(T expected, T actual)
    {
        if (!EqualityComparer<T>.Default.Equals(expected, actual))
        {
            throw new TestFailureException($"Expected {Format(expected)}, got {Format(actual)}.");
        }
    }

    public static void True(bool condition, string message)
    {
        if (!condition)
        {
            throw new TestFailureException(message);
        }
    }

    public static void SequenceEqual<T>(IEnumerable<T> expected, IEnumerable<T> actual)
    {
        T[] expectedArray = expected.ToArray();
        T[] actualArray = actual.ToArray();

        if (!expectedArray.SequenceEqual(actualArray))
        {
            throw new TestFailureException(
                $"Expected [{string.Join(", ", expectedArray)}], got [{string.Join(", ", actualArray)}].");
        }
    }

    private static string Format<T>(T value)
    {
        return value?.ToString() ?? "null";
    }
}
