class Deque {

    private Node head;
    private Node tail;
    private int count =0;

    public Deque() {
        head =null;  tail = null;
    }

    public bool isEmpty() {
        return  count==0;
    }

    public void append(int value) {
        var newNode = new Node(value);

        if(count==0){
            head = tail = newNode;
        }
        else{
            tail.next = newNode;
            newNode.prev = tail;
            tail = newNode;
        }
        count++;
    }

    public void appendleft(int value) {
        var newNode = new Node(value);

        if(count==0){
            head = tail = newNode;
        }
        else{
            newNode.next = head;
            head.prev = newNode;
            head = newNode;
        }
        count++;
    }

    public int pop() {
        if(count == 0) return -1;
        var popped = tail.val;
        if (count == 1)
        {
            head = tail = null;
        }
        else{
          tail = tail.prev;
          tail.next = null;
        }

        count--;
        return popped;
    }

    public int popleft() {
        if(count ==0) return -1;
        var popped = head.val;
         if (count == 1)
        {
            head = tail = null;
        }
        else
        {
            head = head.next;
            head.prev = null;
        }
        count--;
        return popped;
    }
}

public class Node{
    public int val;
    public Node next;
    public Node prev;

    public Node(int val=0, Node next=null,Node prev = null){
        this.val = val;
        this.next = next;
        this.prev = prev;
    }
}