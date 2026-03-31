public class LRUCache {

    private Dictionary<int,LinkedListNode<(int key,int val)>> cache;
    private int capacity;
    private LinkedList<(int key,int val)> order;
    
    public LRUCache(int capacity) {
        cache = new();
        order = new();
        this.capacity = capacity;
    }
    
    public int Get(int key) {
        if(!cache.ContainsKey(key)) return -1;
        var node = cache[key];
        order.Remove(node);
        order.AddLast(node);
        return node.Value.val; 
    }
    
    public void Put(int key, int value) 
    {
        if(cache.ContainsKey(key))
        {
            var node = cache[key];
            
            order.Remove(node);
            node.Value = (key,value);
            order.AddLast(node);
        }
        else{
            if(cache.Count == capacity){
                var lru = order.First.Value;
                order.RemoveFirst();
                cache.Remove(lru.key);
            }
            var newNode = new LinkedListNode<(int key,int val)>((key,value));
            order.AddLast(newNode);
            cache.Add(key,newNode);
        }

    }
}
