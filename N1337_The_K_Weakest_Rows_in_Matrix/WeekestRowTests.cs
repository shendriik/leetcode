namespace N1337_The_K_Weakest_Rows_in_Matrix
{
    using NUnit.Framework;

    public class Tests
    {
        public static IEnumerable<TestCaseData> TestCases()
        {
            yield return new TestCaseData(
                new[]
                {
                    new[] { 1, 1, 0, 0, 0 },
                    new[] { 1, 1, 1, 1, 0 },
                    new[] { 1, 0, 0, 0, 0 },
                    new[] { 1, 1, 0, 0, 0 },
                    new[] { 1, 1, 1, 1, 1 },
                }, 3)
            {
                ExpectedResult = new[] { 2, 0, 3 }
            };

            yield return new TestCaseData(
                new[]
                {
                    new[] { 1, 0, 0, 0 },
                    new[] { 1, 1, 1, 1 },
                    new[] { 1, 0, 0, 0 },
                    new[] { 1, 0, 0, 0 },
                }, 2)
            {
                ExpectedResult = new[] { 0, 2 }
            };
        }

        [TestCaseSource(nameof(TestCases))]
        public int[] KWeakestRows(int[][] mat, int k)
        {
            var heap = new MinHeap<RowData>(mat.Length);
            var index = 0;

            foreach (var row in mat)
            {
                heap.Add(new RowData
                {
                    Number = index++,
                    SoldersCount = row.Sum()
                });
            }

            var result = new int[k];
            for (var i = 0; i < result.Length; i++)
            {
                result[i] = heap.RemoveMin().Number;
            }

            return result;
        }

        internal class RowData : IComparable<RowData>
        {
            public int Number { get; set; }

            public int SoldersCount { get; set; }

            public int CompareTo(RowData other)
            {
                var equals = SoldersCount.CompareTo(other.SoldersCount);

                return equals == 0 ? Number.CompareTo(other.Number) : equals;
            }
        }
    }
}