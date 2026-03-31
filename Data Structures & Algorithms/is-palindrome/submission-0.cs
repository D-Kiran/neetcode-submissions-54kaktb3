public class Solution {
    public bool IsPalindrome(string s) 
    {
        var str = "";
        foreach(var ch in s)
        {
            if(char.IsLetterOrDigit(ch))
            {
                if(char.IsLetter(ch)){
                    str += char.ToLower(ch);
                }
                else{
                    str+=ch;
                }
                
                
            }
        }

        Console.WriteLine(str);

        int start=0; int end = str.Length-1;

        while(start < end){
            if(str[start] != str[end]) return false;
            start++; end--;
        }
        return true;
    }
}
