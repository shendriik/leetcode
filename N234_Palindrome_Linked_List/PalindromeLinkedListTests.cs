namespace N234_Palindrome_Linked_List
{
    using Stuff;
    
    public sealed class PalindromeLinkedListTests
    {
        public bool IsPalindrome(ListNode head)
        {

            var list = new List<int>();
            var start = head;

            var node = head;
            while (node != null)
            {
                list.Add(node.val);
                node = node.next;
            }

            node = start;
            for (var i = list.Count - 1; i >= 0; i--)
            {
                if (list[i] != node.val)
                {
                    return false;
                }

                node = node.next;
            }

            return true;
        }
    }
}
