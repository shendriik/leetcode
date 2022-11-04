namespace N1672_Richest_Customer_Wealth
{
    using System.Collections.Generic;
    using System.Linq;
    using NUnit.Framework;
    
    public class Solution
    {
        public static IEnumerable<TestCaseData> TestCases()
        {
            yield return new TestCaseData(arg:
                new[]
                {
                    new[] { 1, 2, 3 },
                    new[] { 3, 2, 1 }
                })
            {
                ExpectedResult = 6
            };

            yield return new TestCaseData(arg:
                new[]
                {
                    new[] { 1, 5 },
                    new[] { 7, 3 },
                    new[] { 3, 5 }
                })
            {
                ExpectedResult = 10
            };
        }

        [TestCaseSource(nameof(TestCases))]
        public int MaximumWealth(int[][] accounts)
        {
            var max = 0;
            
            foreach (var t in accounts)
            {
                var sum = t.Sum();
                if (sum > max)
                {
                    max = sum;
                }
            }

            return max;
        }
    }
}