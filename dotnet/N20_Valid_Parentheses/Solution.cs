namespace N20_Valid_Parentheses
{
    using System.Collections.Generic;
    using NUnit.Framework;

    public class Solution
    {
        [TestCase("(", ExpectedResult = false)]
        [TestCase(")", ExpectedResult = false)]
        [TestCase("()[]{}", ExpectedResult = true)]
        [TestCase("()", ExpectedResult = true)]
        [TestCase("(]", ExpectedResult = false)]
        [TestCase("(((([[[[{{{{}}}}]]]]))))", ExpectedResult = true)]
        [TestCase("(((([[[[{{{{}}}}]]]])]))", ExpectedResult = false)]
        public bool IsValid(string s)
        {
            var stack = new Stack<char>();
            foreach (var ch in s)
            {
                if (ch is '[' or '(' or '{')
                {
                    stack.Push(ch);
                }
                else
                {
                    if (stack.Count == 0)
                    {
                        return false;
                    }
                    
                    var last = stack.Pop();
                    var expected = ch switch
                    {
                        ']' => '[',
                        ')' => '(',
                        '}' => '{',
                        _ => 0x00
                    };

                    if (last != expected)
                    {
                        return false;
                    }
                }
            }

            return stack.Count == 0;
        }
    }
}