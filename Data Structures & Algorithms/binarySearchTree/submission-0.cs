class TreeMap {

    private Node root;
    private List<int> sortedArray;

    public TreeMap() {
        
    }

    public void Insert(int key, int val) {
        root = Insert(root,key,val);
    }

    public int Get(int key) {
        var node = Get(root,key);
        if(node is null) return -1;
       return node.val;
    }

    public int GetMin() {
        if(root is null) return -1;
        var node = GetMin(root);
        return node.val;
    }

    public int GetMax() {
         if(root is null) return -1;
         var node = GetMax(root);
         return node.val;
    }

    public void Remove(int key) {
        root = Remove(root,key);        
    }

    public List<int> GetInorderKeys() {
        sortedArray = new();
        InOrderTraversal(root,sortedArray);
        return sortedArray;
    }

    private void InOrderTraversal(Node x,List<int> array){
        if(x is null) return;
        InOrderTraversal(x.left,array);
        array.Add(x.key);
        InOrderTraversal(x.right,array);
    }

    private Node Remove(Node x, int key){
        if(x == null) return null;
        if(key < x.key){
            x.left = Remove(x.left,key);
        }
        else if(key > x.key){
            x.right = Remove(x.right,key);
        }
        else{
            if(x.left == null) return x.right;
            if(x.right == null) return x.left;
            Node t = x;
            x = GetMin(t.right);
            x.right = DeleteMin(t.right);
            x.left = t.left;
        }
        return x;
    }

    private Node DeleteMin(Node x){
        if(x.left == null) return x.right;
        x.left= DeleteMin(x.left);
        return x;
    }

    private Node Get(Node x, int key){
        if(x == null) return null;
        if(key < x.key){
            return Get(x.left,key);
        }
        else if(key > x.key){
            return Get(x.right,key);
        }
        else{
            return x;
        }
    }

    private Node Insert(Node x, int key,int value){
        if(x == null) return new Node(key,value);
        if(key < x.key){
            x.left = Insert(x.left,key,value);
        }
        else if(key > x.key){
            x.right = Insert(x.right,key,value);
        }
        else{
            x.val = value;
        }
        return x;
    }

    private Node GetMin(Node x){
        if(x.left == null) return x;
        return GetMin(x.left);
    }

    private Node GetMax(Node x){
        if(x.right == null) return x;
        return GetMax(x.right);
    }
    
    private class Node
    {
        public int key;
        public int val;
        public Node left;
        public Node right;

        public Node(int key,int val){
            this.key = key;
            this.val = val;
            left = null ; right = null;
        }
    }
}
