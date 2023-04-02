namespace N412_FizzBuzz
{
    public class Solution {
        public IList<string> FizzBuzz(int n)
        {
            return Enumerable.Range(1, n)
                .Select(i =>
                    i % 3 != 0 && i % 5 != 0
                        ? i.ToString()
                        : ((i % 3 == 0 ? "Fizz" : string.Empty) + (i % 5 == 0 ? "Buzz" : string.Empty))).ToArray();
        }
    }
}