namespace N876_Middle_Of_The_Linked_List
{
    using Stuff;
    using NUnit.Framework;

    internal sealed class LinkedListMiddleTests
    {
        public static IEnumerable<TestCaseData> TestCases()
        {
            yield return new TestCaseData(
                new ListNode(1,
                    new ListNode(2,
                        new ListNode(3,
                            new ListNode(4,
                                new ListNode(5))))))
            {
                ExpectedResult =
                    new ListNode(3,
                        new ListNode(4,
                            new ListNode(5)))
            };

            yield return new TestCaseData(
                new ListNode(1,
                    new ListNode(2,
                        new ListNode(3,
                            new ListNode(4,
                                new ListNode(5,
                                    new ListNode(6)))))))
            {
                ExpectedResult =
                    new ListNode(4,
                        new ListNode(5,
                            new ListNode(6)))
            };
        }

        [TestCaseSource(nameof(TestCases))]
        public ListNode MiddleNode(ListNode head)
        {
            var slow = head;
            var fast = head;

            while (fast?.next != null)
            {
                slow = slow.next;
                fast = fast.next?.next;
            }

            return slow;
        }
    }
}