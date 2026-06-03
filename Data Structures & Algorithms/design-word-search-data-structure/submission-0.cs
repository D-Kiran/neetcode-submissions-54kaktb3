public class WordDictionary {

    private TrieNode root;

    public WordDictionary() {
        root = new();
    }
    
    public void AddWord(string word) {
        var current = root;
        foreach(var ch in word)
        {
            if(!current.children.ContainsKey(ch)){
                current.children[ch] = new TrieNode();
            }
            current = current.children[ch];
        }

        current.endOfWord = true;
        
    }
    
    public bool Search(string word) {
        return Dfs(word,0,root);
    }

    private bool Dfs(string word,int j,TrieNode root){
        var current = root;
        for(int i=j ; i<word.Length;i++){
            char ch = word[i];
            if(ch == '.'){
                foreach(var kvp in current.children){
                    if(Dfs(word,i+1,kvp.Value)) return true;
                }
                return false;
            }

            else{
                if(!current.children.ContainsKey(ch)) return false;
                current = current.children[ch];
            }
        }

        return current.endOfWord;
    }
}

public class TrieNode{
    public Dictionary<char,TrieNode> children = new();
    public bool endOfWord = false;
}
