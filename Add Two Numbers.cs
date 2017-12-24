/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
        int al=1;
            int bl=1;
            int l;
            int s;
            ListNode temp = l1;
            while (true)
            {
                if (temp.next != null)
                {
                    al += 1;
                    temp = temp.next;
                }
                else
                {
                    break;
                }
            }
            temp = l2;
            while (true)
            {
                if (temp.next != null)
                {
                    bl += 1;
                    temp = temp.next;
                }
                else
                {
                    break;
                }
            }


            ListNode main;
            ListNode second;
            if (al >= bl)
            {
                main = l1;
                second = l2;
                l = al;
                s = bl;
            }
            else
            {
                main = l2;
                second = l1;
                l = bl;
                s = al;
            }

            ListNode result = main;
            int countb = 1;
            for (int i = 1; i <= l; i++)
            {
                if (countb<=s)
                {
                    main.val += second.val;
                    second = second.next;
                    countb++;
                }


                if (main.val >= 10)
                {
                    main.val -= 10;
                    if (i == l)
                    {
                        ListNode newnode = new ListNode(1);
                        main.next = newnode;


                    }
                    else
                    {
                        main.next.val += 1;
                    }
                }
                main = main.next;
            }
            return result ;
    }
}