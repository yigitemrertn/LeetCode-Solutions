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
public class Solution {
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
        ListNode head = new ListNode();
        ListNode p = head;
        int c = 0;
        while(l1 != null || l2!=null ||c == 1){
            int val = c;
            c = 0;
            if(l1 !=null){
                val += l1.val;
                l1 = l1.next;
            }
            if(l2 !=null){
                val += l2.val;
                l2 = l2.next;
            }
            if (val >=10){
                c = 1;
                val -=10;
            }
            
            p.val = val;
            if(!(l1 != null || l2!=null ||c == 1)) break;
            p.next = new ListNode();
            p = p.next;
        }
        return head;
    }
}
