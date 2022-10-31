namespace Stuff
{
    using System;
    
    public class ListNode : IEquatable<ListNode>
    {
        public int val;
        public ListNode next;

        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }

        public bool Equals(ListNode other)
        {
            if (other == null)
            {
                return false;
            }

            var x = other;
            var y = this;

            while (x != null && y != null)
            {
                if (x.val != y.val)
                {
                    return false;
                }

                x = x.next;
                y = y.next;
            }

            return x == null && y == null;
        }
    }
}
