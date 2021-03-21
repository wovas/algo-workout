namespace AlgoWorkout.Educative
{
    public static class BinarySearch
    {
        public static int Search(int[] arr, int target)
        {
            return Search(arr, target, 0, arr.Length - 1);
        }

        private static int Search(int[] arr, int target, int left, int right)
        {
            while (left <= right)
            {
                int mid = (right - left) / 2 + left;
                if (arr[mid] == target)
                {
                    return mid;
                }

                if (arr[mid] > target)
                {
                    return Search(arr, target, left, mid - 1);
                }
                else if (arr[mid] < target)
                {
                    return Search(arr, target, mid + 1, right);
                }
            }

            return -1;
        }
    }
}
