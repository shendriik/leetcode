namespace N21_Merge_Two_Sorted_Lists
{
    using System.Collections.Generic;
    using NUnit.Framework;
    using Stuff;

    public class Solution
    {
        public static IEnumerable<TestCaseData> TestCases()
        {
            yield return new TestCaseData(
                new ListNode(1,
                    new ListNode(2,
                        new ListNode(4))),
                new ListNode(1,
                    new ListNode(3,
                        new ListNode(4))))
            {
                ExpectedResult =
                    new ListNode(1,
                        new ListNode(1,
                            new ListNode(2,
                                new ListNode(3,
                                    new ListNode(4,
                                        new ListNode(4)))))),
            };
            yield return new TestCaseData(null, null) { ExpectedResult = null };
            yield return new TestCaseData(null, new ListNode(0)) { ExpectedResult = new ListNode(0) };
        }

        [TestCaseSource(nameof(TestCases))]
        public ListNode MergeTwoLists(ListNode list1, ListNode list2)
        {
            return MergeTwoListsImpl(list1, list2);
        }

        private ListNode MergeTwoListsImpl(ListNode node1, ListNode node2)
        {
            if (node1 == null && node2 == null)
            {
                return null;
            }

            if (node1 == null)
            {
                return node2;
            }

            if (node2 == null)
            {
                return node1;
            }

            ListNode node;

            if (node1.val <= node2.val)
            {
                node = node1;
                node.next = MergeTwoListsImpl(node1.next, node2);
            }
            else
            {
                node = node2;
                node.next = MergeTwoListsImpl(node1, node2.next);
            }

            return node;
        }
    }
}