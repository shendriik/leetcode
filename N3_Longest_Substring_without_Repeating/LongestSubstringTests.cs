namespace N3_Longest_Substring_without_Repeating
{
    using NUnit.Framework;

    internal sealed class LongestSubstringTests
    {
        public int LengthOfLongestSubstring(string s)
        {
            var max = 0;
            var usage = new HashSet<char>();

            foreach (var ch in s)
            {
                if (usage.Contains(ch))
                {
                    if (usage.Count > max)
                    {
                        max = usage.Count;
                    }
                    
                    usage.Clear();
                }
                
                usage.Add(ch);
            }

            return Math.Max(max, usage.Count);
        }
        
        [TestCase("abcabcbb", ExpectedResult = 3)]
        [TestCase("bbbbb", ExpectedResult = 1)]
        [TestCase("pwwkew", ExpectedResult = 3)]
        [TestCase("123456712345678", ExpectedResult = 8)]
        [TestCase("a", ExpectedResult = 1)]
        [TestCase("", ExpectedResult = 0)]
        
        public int Tests(string input)
        {
            return LengthOfLongestSubstring(input);
        }
    }
}