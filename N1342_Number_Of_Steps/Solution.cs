namespace N1342_Number_Of_Steps
{
    using NUnit.Framework;

    internal sealed class Solution
    {

        [TestCase(14, ExpectedResult = 6)]
        [TestCase(8, ExpectedResult = 4)]
        public int NumberOfSteps(int num)
        {
            var start = num;
            var i = 0;

            while (start != 0)
            {
                if ((start & 1) == 1)
                {
                    start--;
                }
                else
                {
                    start >>= 1;
                }

                i++;
            }

            return i;
        }
    }
}
