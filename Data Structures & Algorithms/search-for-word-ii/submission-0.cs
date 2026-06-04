public class Solution {
    public List<string> FindWords(char[][] board, string[] words) {
        var visited = new HashSet<(int row,int col)>();
        var result = new HashSet<string>();

        var root = new TrieNode();
        foreach(var word1 in words){
            root.AddWord(word1);
        }

        int ROWS = board.Length; int COLS = board[0].Length;

        for(int row = 0; row<ROWS; row++){
            for(int col=0; col<COLS; col++){
                Dfs(row,col,root,"");
            }
        }

        return new List<string>(result);


        void Dfs(int r, int c,TrieNode node , string word){
            if(r < 0 || c <0 || r==ROWS ||c == COLS || visited.Contains((r,c)) 
                || !node.children.ContainsKey(board[r][c])){
                    return;
                } 

                visited.Add((r,c));
                node = node.children[board[r][c]];
                word += board[r][c];

                if(node.isEndOfWord){
                    result.Add(word);
                }

                Dfs(r+1,c,node,word);
                Dfs(r-1,c,node,word);
                Dfs(r,c+1,node,word);
                Dfs(r,c-1,node,word);

                visited.Remove((r,c));
        } 
    }
}

public class TrieNode{
    public Dictionary<char,TrieNode> children = new();
    public bool isEndOfWord = false;

    public void AddWord(string word){
        var current = this;
        foreach(var ch in word){
            if(!current.children.ContainsKey(ch)){
                current.children[ch] = new TrieNode();
            }
            current = current.children[ch];
        }

        current.isEndOfWord = true;
    }
}