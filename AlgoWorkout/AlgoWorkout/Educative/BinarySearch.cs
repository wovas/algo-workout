using System;

namespace AlgoWorkout.Educative
{
    public static class BinarySearch
    {
        public static int FindBoolBoundary(bool[] arr)
        {
            int left = 0;
            int right = arr.Length - 1;
            return BoundaryInternal(left, right, (i) => arr[i] == true);
        }

        public static int NotSmallerThenLargest(int[] arr, int target)
        {
            int left = 0;
            int right = arr.Length - 1;
            return BoundaryInternal(left, right, (i) => arr[i] >= target);
        }

        public static int FirstOccurence(int[] arr, int target)
        {
            int left = 0;
            int right = arr.Length - 1;
            return BoundaryInternal(left, right, (i) => arr[i] == target);
        }

        public static int Sqrt(int number)
        {
            int left = 1;
            int right = number;
            return BoundaryInternal(left, right, (i) => i >= number / i);
        }

        public static int RotatedPivotPoint(int[] arr)
        {
            int left = 0;
            int right = arr.Length - 1;
            return BoundaryInternal(left, right, (i) => arr[i] <= arr[arr.Length - 1]);
        }

        public static int PeakArray(int[] arr)
        {
            int left = 0;
            int right = arr.Length - 1;
            return BoundaryInternal(left, right, (i) => i == arr.Length - 1 || arr[i] >= arr[i + 1]);
        }

        private static int BoundaryInternal(int left, int right, Func<int, bool> predicate) 
        {
            int boundaryIndex = -1;
            while (left <= right)
            {
                var mid = (right - left) / 2 + left;
                if (predicate(mid))
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
