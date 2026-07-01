namespace DSATraining.Tests;

public sealed class TestFailureException : Exception
{
    public TestFailureException(string message) : base(message)
    {
    }
}
