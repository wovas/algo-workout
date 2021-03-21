using System;

namespace AlgoWorkout.Educative
{
    public static class BinarySearch
    {
        public static int FindBoolBoundary(bool[] arr)
        {
            return BoundaryInternal<bool>(arr, (a, i) => a[i] == true);
        }

        public static int NotSmallerThenLargest(int[] arr, int target)
        {
            return BoundaryInternal(arr, (a, i) => a[i] >= target);
        }

        public static int FirstOccurence(int[] arr, int target)
        {
            return BoundaryInternal(arr, (a, i) => a[i] == target);
        }

        private static int BoundaryInternal<T>(T[] arr, Func<T[], int, bool> predicate) 
        {
            int left = 0;
            int right = arr.Length - 1;
            int boundaryIndex = -1;
            while (left <= right)
            {
                var mid = (right - left) / 2 + left;
                if (predicate(arr, mid))
                {
                    boundaryIndex = mid;
                    right = mid - 1;
                }
                else
                {
                    left = mid + 1;
                }
            }

            return boundaryIndex;
        }

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
