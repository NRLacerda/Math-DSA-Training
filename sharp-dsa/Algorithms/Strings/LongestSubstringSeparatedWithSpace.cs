using System;
using System.Collections.Generic;

public class Test
{
    public int GetLowestItem(int[] arr)
    {
        /*
            Input: nums = [4,5,0,1,2,3]

            Input: nums = [3,4,5,6,1,2]

            Input: nums = [5,0,1,2,3,4]

            Input: nums = [4,5,6,7]
        */

        string abc = "abc";
        abc = new string(abc.OrderByDescending(c => c).ToArray());
        Dictionary<string, List<string>> anagramGroup = new Dictionary<string, List<string>>();

        anagramGroup["abc"].Add(abc);

        

        if (arr.Length == 1) return arr[0];

        if (arr[0] < arr[arr.Length - 1])
        {
            return arr[0];
        }

        int lowestValue = -1;
        int pivot = arr.Length / 2;

        while (pivot >= 0 && pivot <= arr.Length - 1)
            if (arr[pivot] < arr[arr.Length - 1])
            {
                lowestValue = Math.Min(arr[pivot], lowestValue);
                pivot = pivot / 2;
            }
            else
            {
                lowestValue = Math.Min(arr[pivot], lowestValue);
                pivot = pivot + arr.Length / 2;
            }

        return lowestValue;
    }


    public void RunTests()
    {
        List<int[]> inputs = new List<int[]>();
        List<int> outputs = new List<int>();
        List<int> expected = new List<int>();

        // Test 0
        inputs.Add(new int[] { 4, 5, 0, 1, 2, 3 });
        expected.Add(0);

        // Test 1
        inputs.Add(new int[] { 3, 4, 5, 6, 1, 2 });
        expected.Add(1);

        // Test 2
        inputs.Add(new int[] { 5, 6, 1, 2, 3, 4 });
        expected.Add(1);

        // Test 3
        inputs.Add(new int[] { 4, 5, 6, 7 });
        expected.Add(4);

        // Run tests
        for (int i = 0; i < inputs.Count; i++)
        {
            int result = GetLowestItem(inputs[i]);
            outputs.Add(result);

            string status = result == expected[i] ? "PASS" : "FAIL";
            Console.WriteLine($"Test {i}: {status} | Input: [{string.Join(", ", inputs[i])}] | Output: {result} | Expected: {expected[i]}");
        }
    }
}