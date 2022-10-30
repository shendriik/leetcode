namespace N234_Palindrome_Linked_List
{

    public class ListNode
    {
        public int Val;
        public ListNode Next;

        public ListNode(int val = 0, ListNode next = null)
        {
            this.Val = val;
            this.Next = next;
        }
    }

    public class Solution
    {
        public bool IsPalindrome(ListNode head)
        {

            var list = new List<int>();
            var start = head;

            ListNode node = head;
            while (node != null)
            {
                list.Add(node.Val);
                node = node.Next;
            }

            node = start;
            for (var i = list.Count - 1; i >= 0; i--)
            {
                if (list[i] != node.Val)
                {
                    return false;
                }

                node = node.Next;
            }

            return true;
        }
    }
}
