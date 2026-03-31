class Deque {

    private Node head;
    private Node tail;
    private int count =0;

    public Deque() {
        head = new(); tail = new();
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
            head = newNode;
        }
        count++;
    }

    public int pop() {
        if(count ==0) return -1;
        var current = head;
        while(current.next!= null && current.next.next!=null){
            current = current.next;
        }
        var popped = tail.val;
        tail = current;
        tail.next=null;
        count--;
        return popped;
    }

    public int popleft() {
        if(count ==0) return -1;
        var popped = head.val;
        count--;
        head = head.next;
        return popped;
    }
}

public class Node{
    public int val;
    public Node next;

    public Node(int val=0, Node next=null){
        this.val = val;
        this.next = next;
    }
}