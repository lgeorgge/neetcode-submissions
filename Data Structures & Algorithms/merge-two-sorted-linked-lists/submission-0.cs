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
    public ListNode MergeTwoLists(ListNode list1, ListNode list2) {
          if (list1 is null)
            return list2;
        if (list2 is null)
            return list1;

        var mainL = list1.val < list2.val ? list1 : list2;
        var otherL = mainL == list1 ? list2 : list1;

        var head = mainL;

        while (mainL is not null) {
            
            if (mainL.next is null)
            {
                mainL.next = otherL;
                break;
            }
            if (mainL.next.val > otherL.val)
            {
                var temp = mainL.next;
                mainL.next = otherL;
                otherL = temp;
            }
            mainL = mainL.next;
        }
        return head;
    }
}