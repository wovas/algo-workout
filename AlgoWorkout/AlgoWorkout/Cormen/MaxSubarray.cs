namespace AlgoWorkout.Cormen
{
    public class MaxSubarray
    {
        public int BruteForce(int[] input) 
        {
            var diff = GetDifferencesArray(input);

            int max = int.MinValue;
            for (int i = 0; i< diff.Length; i++)
            {
                int sum = 0;
                for (int j = i; j < diff.Length; j++)
                {
                    sum += diff[j];
                    max = sum > max ? sum : max;
                }
            }

            return max;
        }

        public int DivideAndConquer(int[] input)
        {
            return FindMaxArray(GetDifferencesArray(input), 0, input.Length - 1).sum;
        }

        private (int leftBound, int rightBound, int sum) FindMaxArray(int[] array, int leftBound, int rightBound)
        {
            if (leftBound == rightBound)
            {
                return (leftBound, rightBound, array[rightBound]);
            }
            
            var mid = (rightBound - leftBound) / 2 + leftBound;
            var leftRes = FindMaxArray(array, leftBound, mid);
            var rightRes = FindMaxArray(array, mid + 1, rightBound);

            var midRes = FindCrossingSum(array, leftBound, rightBound, mid);

            if (leftRes.sum >= rightRes.sum && leftRes.sum >= midRes.sum)
                return (leftBound: leftRes.leftBound, rightBound: leftRes.rightBound, sum: leftRes.sum);
            else if (leftRes.sum <= rightRes.sum && rightRes.sum >= midRes.sum)
                return (leftBound: rightRes.leftBound, rightBound: rightRes.rightBound, sum: rightRes.sum);
            else 
                return (leftBound: midRes.leftIndex, rightBound: midRes.rightIndex, sum: midRes.sum);
        }

        private (int leftIndex, int rightIndex, int sum) FindCrossingSum(int[] array, int leftIndex, int rightIndex, int midIndex) 
        {
            int leftSum = int.MinValue;
            int sum = 0;
            int leftMinIndex = midIndex;
            for (int i = midIndex; i >= leftIndex; i--)
            {
                sum += array[i];
                if (leftSum <= sum)
                {
                    leftSum = sum;
                    leftMinIndex = i;
                }
            }

            int rightSum = int.MinValue;
            int rightMaxIndex = midIndex;
            sum = 0;
            for (int i = midIndex + 1; i <= rightIndex; i++)
            {
                sum += array[i];
                if (rightSum <= sum)
                {
                    rightSum = sum;
                    rightMaxIndex = i;
                }
            }

            return (leftMinIndex, rightMaxIndex, leftSum + rightSum);
        }

        private int[] GetDifferencesArray(int[] input)
        {
            int[] diff = new int[input.Length];

            for (int i = 1; i < input.Length; i++)
            {
                diff[i] = input[i] - input[i - 1];
            }
            return diff;
        }
    }
}
