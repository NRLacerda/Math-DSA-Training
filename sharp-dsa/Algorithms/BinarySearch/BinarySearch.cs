namespace DSATraining.sharp_dsa.Algorithms.BinarySearch
{
    public class BinarySearch
    {
        public int GetIndexOf(int[] arr, int value)
        {
            int left = 0;
            int right = arr.Length - 1;

            while(left <= right)
            {
                int mid = (left + right) / 2;

                if (arr[mid] == value) return mid;

                if (arr[mid] < value) left = mid + 1;
                if (arr[mid] > value) right = mid - 1;
            }

            return -1; // no index found
        }
    }
}
