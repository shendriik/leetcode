namespace N1_Two_Sum
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using NUnit.Framework;

    public class Solution
    {
        public static IEnumerable<TestCaseData> TestCases()
        {
            yield return new TestCaseData(new[] { 2, 7, 11, 15 }, 9) { ExpectedResult = new[] { 0, 1 } };
            yield return new TestCaseData(new[] { 3, 2, 4 }, 6) { ExpectedResult = new[] { 1, 2 } };
            yield return new TestCaseData(new[] { 3, 3 }, 6) { ExpectedResult = new[] { 0, 1 } };
        }

        [TestCaseSource(nameof(TestCases))]
        public int[] TwoSumBruteForce(int[] nums, int target)
        {
            for (var i = 0; i < nums.Length; i++)
            {
                for (var j = 0; j < nums.Length; j++)
                {
                    if (i == j)
                    {
                        continue;
                    }

                    if (nums[i] + nums[j] == target)
                    {
                        return new[] { i, j };
                    }
                }
            }

            return Array.Empty<int>();
        }

        [TestCaseSource(nameof(TestCases))]
        public int[] TwoSumHash(int[] nums, int target)
        {
            var map = new Dictionary<int, List<int>>();

            for (var i = 0; i < nums.Length; i++)
            {
                var num = nums[i];
                if (!map.ContainsKey(num))
                {
                    map.Add(num, new List<int> { i });
                    continue;
                }

                // if we have more that 2 equal values they cannot be problem solution,
                // because there is only one solution pair
                if (map[num].Count == 1)
                {
                    map[num].Add(i);
                }
            }

            for (var i = 0; i < nums.Length; i++)
            {
                if (!map.TryGetValue(target - nums[i], out var v))
                {
                    continue;
                }
                
                var value = v.SingleOrDefault(vv => vv != i);
                if (value != default)
                {
                    return new[] { i, value };
                }
            }

            return Array.Empty<int>();
        }
        
        [TestCaseSource(nameof(TestCases))]
        public int[] TwoSumHashOptimize(int[] nums, int target)
        {
            var map = new Dictionary<int, int>();

            var odd = (target & 1) == 0;
            var divided = target >> 1;
            
            for (var i = 0; i < nums.Length; i++)
            {
                var num = nums[i];
                if (!map.ContainsKey(num))
                {
                    map.Add(num, i);
                    continue;
                }

                if (odd && divided == num)
                {
                    return new[] { map[num], i };
                }
            }

            for (var i = 0; i < nums.Length; i++)
            {
                if (map.TryGetValue(target - nums[i], out var v) && v != i)
                {
                    return new[] { i, v };
                }
            }

            return Array.Empty<int>();
        }
    }
}