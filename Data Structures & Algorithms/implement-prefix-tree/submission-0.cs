public class PrefixTree {

    private TrieNode root;

    public PrefixTree() {
        root = new();
    }
    
    public void Insert(string word) {
        var current = root;
        foreach(var ch in word){
            if(!current.children.ContainsKey(ch)){
                current.children[ch] = new TrieNode();
            }
            current = current.children[ch];
        }
        current.endOfWord = true;
    }
    
    public bool Search(string word) {
        var current = root;
        foreach(var ch in word){
            if(!current.children.ContainsKey(ch)) return false;
            current = current.children[ch];
        }
        return current.endOfWord;
    }
    
    public bool StartsWith(string prefix) {
        var current = root;
        foreach(var ch in prefix){
            if(!current.children.ContainsKey(ch)) return false;
            current = current.children[ch];
        }

        return true;
    }
}

public class TrieNode{
    public Dictionary<char,TrieNode> children = new();

    public bool endOfWord = false;
}
