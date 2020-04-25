/*
Design and implement a data structure for Least Recently Used (LRU) cache. It should support the following operations: get and put.

get(key) - Get the value (will always be positive) of the key if the key exists in the cache, otherwise return -1.
put(key, value) - Set or insert the value if the key is not already present. When the cache reached its capacity, it should invalidate the least recently used item before inserting a new item.

The cache is initialized with a positive capacity.

Follow up:
Could you do both operations in O(1) time complexity?

Example:

LRUCache cache = new LRUCache( 2 );

cache.put(1, 1);
cache.put(2, 2);
cache.get(1);       // returns 1
cache.put(3, 3);    // evicts key 2
cache.get(2);       // returns -1 (not found)
cache.put(4, 4);    // evicts key 1
cache.get(1);       // returns -1 (not found)
cache.get(3);       // returns 3
cache.get(4);       // returns 4
*/

public class LRUCache {
    Dictionary<int, int> kvps = new Dictionary<int, int>();
    Dictionary<int, LinkedListNode<int>> kvns = new Dictionary<int, LinkedListNode<int>>();
    LinkedList<int> list = new LinkedList<int>();
    
    int Capacity;
    
    public LRUCache(int capacity) {
        Capacity = capacity;
    }
    
    public int Get(int key) {
        if (!kvps.ContainsKey(key)) return -1;
        var res = kvps[key];
        var node = kvns[key];
        list.Remove(node);
        list.AddFirst(node);
        return res;
    }
    
    public void Put(int key, int value) {
        if (!kvps.ContainsKey(key)){
            // New:
            if (Capacity == list.Count){
                var last = list.Last;
                list.RemoveLast();
                kvps.Remove(last.Value);
                kvns.Remove(last.Value);
            }
            list.AddFirst(key);
            kvns[key] = list.First;
            kvps[key] = value;
        }
        else{
            // Update:
            kvps[key] = value;
            var node = kvns[key];
            list.Remove(node);
            list.AddFirst(node);
        }
    }
}

/*
 * Your LRUCache object will be instantiated and called as such:
 * LRUCache obj = new LRUCache(capacity);
 * int param_1 = obj.Get(key);
 * obj.Put(key,value);
 */
