using DSA.InternalMath.Sigma;

namespace DSATraining.Tests.InternalMath;

public static class SigmaTests
{
    public static IEnumerable<TestCase> All()
    {
        yield return new TestCase("Sigma formula returns triangular sum", () =>
        {
            var sigma = new Sigma();

            int result = sigma.SigmaFromNumber(3);

            Assert.Equal(6, result);
        });

        yield return new TestCase("Recursive sigma returns triangular sum", () =>
        {
            var sigma = new Sigma();

            int result = sigma.RecursiveSigma(4);

            Assert.Equal(10, result);
        });

        yield return new TestCase("Full sigma applies a function over a range", () =>
        {
            var sigma = new Sigma();

            int result = sigma.FullSigmaChad(x => x * 2, 1, 3);

            Assert.Equal(12, result);
        });
    }
}
