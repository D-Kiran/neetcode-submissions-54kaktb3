public class TimeMap {

    private Dictionary<string,List<Tuple<int,string>>> dict;

    public TimeMap() {
        dict = new();
        
    }
    
    public void Set(string key, string value, int timestamp) {
       if(!dict.ContainsKey(key))
       {
          dict[key] = new List<Tuple<int,string>>();
       }
       dict[key].Add(Tuple.Create(timestamp,value));
        
    }
    
    public string Get(string key, int timestamp) 
    {
        if(!dict.ContainsKey(key)) return "";
         return BinarySearch(dict[key],timestamp);
    }



    private string BinarySearch(List<Tuple<int,string>> list, int target)
    {
        int left= 0; int right = list.Count-1; string result ="";
        
        while(left < list.Count && right >= 0 && left <= right)
        {
            int mid = (right+left)/2;
            if(list[mid].Item1 == target) return list[mid].Item2;
            else if(list[mid].Item1 < target)
            {
                result = list[mid].Item2;
                left = mid+1;               
            } 
            else if(list[mid].Item1 > target) right = mid-1;         
        }
        
        return result;
    }
}
