public class LinkedList {

    private Node linkedList;
    private Node head;
    private Node tail;
    private int count=0;

    public LinkedList() {
        linkedList = new(0,null);
        head = new(0,null); tail = new(0,null);
    }

    public int Get(int index) {
        if(index >= count) return -1;
        if(index ==0) return head.data;
        else if(index == count-1) return tail.data;
        else{
            int i=0;
            var current = head;
            while(i < index){
                current = current.next;
                i++;
            }
            return current.data;
        }
    }

    public void InsertHead(int val) {
        if(count ==0){
            linkedList.data=val;
            head = tail = linkedList;           
        }
        else{
            var newNode = new Node(val,null);
            newNode.next = head;
            head = newNode;
            
        }
        count++;
    }

    public void InsertTail(int val) {
        if(count ==0){
            linkedList.data=val;
            head = tail = linkedList;           
        }
        else{
            var newNode =new Node(val,null);
            tail.next = newNode;
            tail = newNode;
        }
        count++;
    }

    public bool Remove(int index) {
        if(index >= count) return false;
        if(index ==0) head =head.next;
        else if(index == count-1){
            int i = 1; 
            var current = head;
            while(i<index){
                current = current.next;
                i++;
            }
            current.next = null;
            tail = current;
        }
        else{
            int i = 1; Node current = head;
            while(i<index){
                current = current.next;
                i++;
            }
            current.next = current.next.next;
        }
        count--;
        return true;
    }

    public List<int> GetValues() 
    {         
        var values = new List<int>();
        if(count ==0) return values;
        var current = head;
        while(current != null){
            values.Add(current.data);
            current = current.next;
        }
        return values;
    }
}

public class Node{
    public int data;
    public Node next;

    public Node(int data, Node next){
        this.data = data;
        this.next = next;
    }
}