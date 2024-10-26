namespace N1337_The_K_Weakest_Rows_in_Matrix;

using System.Collections.Immutable;
using NUnit.Framework;

public class MinHeapTests
{
    [Test]
    public void Should_get_sorted_data_from_min_heap()
    {
        var expected = new[] { 4, 7, 2, 3, 1, 5, 9, 8, 6 };

        var minHeap = new MinHeap<int>(expected.Length);
        
        foreach (var i in expected)
        {
            minHeap.Add(i);
        }
        
        foreach (var i in expected.ToImmutableSortedSet())
        {
            Assert.That(minHeap.RemoveMin(), Is.EqualTo(i));
        }
    }
}