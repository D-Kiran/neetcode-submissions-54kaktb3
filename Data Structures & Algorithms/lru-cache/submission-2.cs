public class LRUCache {

    private Dictionary<int, LinkedListNode<(int key,int value)>> cache;
    private int capacity;
    private LinkedList<(int key,int value)> order;

    public LRUCache(int capacity) {
        cache = new();
        this.capacity = capacity;
        order = new();
    }
    
    public int Get(int key) {
        if(!cache.ContainsKey(key)) return -1;
        var node = cache[key];
        order.Remove(node);
        order.AddLast(node);
        return node.Value.value;
    }
    
    public void Put(int key, int value) 
    {
        if(cache.ContainsKey(key)){
            var node = cache[key];
            order.Remove(node);
            node.Value = (key,value);
            order.AddLast(node);
        }
        else{
            if(cache.Count == capacity){
                var lruNode = order.First.Value;
                order.RemoveFirst();
                cache.Remove(lruNode.key);
            }
            var newNode = new LinkedListNode<(int key, int value)>((key,value));
            order.AddLast(newNode);
            cache[key] = newNode;
        }
    }
}
