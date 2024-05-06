/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
public class Solution
{
    public ListNode RemoveNodes(ListNode head)
    {
        if (head == null || head.next == null) return head;

        ListNode result = RemoveNodes(head.next);
        if (result.val > head.val) return result;
        head.next = result;
        return head;
    }
}