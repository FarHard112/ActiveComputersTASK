using System;

namespace ActiveComputersTASK.Models
{
    public class LinkedList
    {


        public Node head1, head2;

        public class Node
        {
            public int data;
            public Node next;

            public Node(int d)
            {
                data = d;
                next = null;
            }
        }


        public Node addTwoLists(Node first, Node second)
        {

            Node res = null;
            Node prev = null;
            Node temp = null;
            int carry = 0, sum;


            while (first != null || second != null)
            {

                sum = carry + (first != null ? first.data : 0)
                      + (second != null ? second.data : 0);


                carry = (sum >= 10) ? 1 : 0;


                sum = sum % 10;


                temp = new Node(sum);


                if (res == null)
                {
                    res = temp;
                }


                else
                {
                    prev.next = temp;
                }


                prev = temp;


                if (first != null)
                {
                    first = first.next;
                }
                if (second != null)
                {
                    second = second.next;
                }
            }

            if (carry > 0)
            {
                temp.next = new Node(carry);
            }


            return res;
        }


        public void printList(Node head)
        {
            while (head != null)
            {
                Console.Write(head.data + " ");
                head = head.next;
            }
            Console.WriteLine("");
        }
    }
}
