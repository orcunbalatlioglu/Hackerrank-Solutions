    static SinglyLinkedListNode insertNodeAtTail(SinglyLinkedListNode head, int data) {
        SinglyLinkedListNode newNode = new SinglyLinkedListNode(data);
        if(head is not null){
            SinglyLinkedListNode node = head;
            while(node.next != null){
                node = node.next;
            }
            node.next = newNode;
            return head;
        }
        else{
            return newNode;
        }
    }