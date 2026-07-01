using DSATraining.sharp_dsa.Algorithms.BinarySearch;

namespace DSATraining.Tests.Algorithms;

public static class BinarySearchTests
{
    public static IEnumerable<TestCase> All()
    {
        yield return new TestCase("Binary search finds an existing value", () =>
        {
            var binarySearch = new BinarySearch();

            int result = binarySearch.GetIndexOf([0, 1, 2, 3, 4], 4);

            Assert.Equal(4, result);
        });

        yield return new TestCase("Binary search returns -1 when value is missing", () =>
        {
            var binarySearch = new BinarySearch();

            int result = binarySearch.GetIndexOf([0, 1, 2, 3, 4], 9);

            Assert.Equal(-1, result);
        });
    }
}
