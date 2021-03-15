using System;

namespace AlgoWorkout.Cormen
{
    public class MaxSubarray
    {
        public int BruteForce(int[] input) 
        {
            int[] diff = new int[input.Length];

            for (int i = 1; i< input.Length; i++)
            {
                diff[i] = input[i] - input[i - 1];
            }

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
            return 0;
        }
    }
}
