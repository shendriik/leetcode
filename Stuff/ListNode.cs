namespace Stuff
{
    using System;
    using System.Text;

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

        public override string ToString()
        {
            var x = this;
            var builder = new StringBuilder();
            while (x != null)
            {
                builder.Append($"{x.val}->");
                x = x.next;
            }

            return builder.ToString();
        }
    }
}
