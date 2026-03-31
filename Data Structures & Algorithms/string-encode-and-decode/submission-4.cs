public class Solution {

    public string Encode(IList<string> strs) 
    {
        StringBuilder sb = new StringBuilder();
        for(int i=0; i<strs.Count; i++)
        {
            var length = strs[i].Length;
            sb.Append(length);
            sb.Append("#");
            sb.Append(strs[i]);
        }
        return sb.ToString();
    }

    public List<string> Decode(string s) 
    {
        var output = new List<string>();
        int i=0; int j=0;
        while(i < s.Length)
        {
            string length="";
            while(s[j] != '#')
            {
               length+= s[j];
               j++;
            }
           int len = int.Parse(length);
           i = j+1;          
           output.Add(s.Substring(i,len));
           j = i+len;
           i=j;
        }
        

        return output;
    }

}
