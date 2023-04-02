namespace N53_Maximum_Subarray
{
    using System;
    using NUnit.Framework;

    public class Solution
    {
        /// <summary>
        /// Known as Kadane's alg.
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        [TestCase(new[] { 1 }, ExpectedResult = 1)]
        [TestCase(new[] { -1 }, ExpectedResult = -1)]
        [TestCase(new[] { -1, -2 }, ExpectedResult = -1)]
        [TestCase(new[] { 5, 4, -1, 7, 8 }, ExpectedResult = 23)]
        [TestCase(new[] { 1, 2, 3, 4, 5, 6, 7 }, ExpectedResult = 28)]
        [TestCase(new[] { 0, 0, 0, 0, 1, 0, 0, 0, 0 }, ExpectedResult = 1)]
        [TestCase(new[] { -2, 1, -3, 4, -1, 2, 1, -5, 4 }, ExpectedResult = 6)]
        [TestCase(new[] { -1, -2, -3, -4, -5, -4, -3, -2, -1 }, ExpectedResult = -1)]
        [TestCase(new[] { -1, -2, -3, -4, -5, -4, -3, -2, -1 }, ExpectedResult = -1)]
        public int MaxSubArray(int[] nums)
        {
            var sum = 0;
            var bestSum = int.MinValue;
            
            foreach (var num in nums)
            {
                sum = Math.Max(num, sum + num);
                
                if (sum > bestSum)
                {
                    bestSum = sum;
                }
            }

            return bestSum;
        }
    }
}