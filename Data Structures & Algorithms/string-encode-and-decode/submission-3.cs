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
        Console.WriteLine(s);
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
           Console.WriteLine(length);
           int len = int.Parse(length);
           i = j+1;
           
           var sub = s.Substring(i,len);
           Console.WriteLine(sub);
           output.Add(sub);
            j = i+len;
            Console.WriteLine(i);
           i=j;
        }
        

        return output;
    }

}
