public class TimeMap {

    private Dictionary<string,string> dict;

    public TimeMap() {
        dict = new();
        
    }
    
    public void Set(string key, string value, int timestamp) {
        var keyupdated = CreateKey(key,timestamp);
        dict[keyupdated] = value;
    }
    
    public string Get(string key, int timestamp) 
    {
        var list = new List<int>();
        foreach(var kvp in dict){
            
            var splitarray = kvp.Key.Split(",");
            if(!splitarray[0].Equals(key)) continue;
            list.Add(int.Parse(splitarray[1]));
        }
        if(list.Count == 0) return "";
        list.Sort();
       var (propertimestamp,lessthantargetexists) =  BinarySearch(list, timestamp);
       if(!lessthantargetexists) return "";
       var keytofind = CreateKey(key,propertimestamp);
       return dict[keytofind];
    }

    private string CreateKey(string key, int time){
        return string.Join(",", key, time.ToString());
    }

    private (int,bool) BinarySearch(List<int> list, int target)
    {
        int left= 0; int right = list.Count-1; int mid=0;
        bool lessthantargetexists = false;

        while(left < list.Count && right >= 0 && left <= right)
        {
             mid = (right+left)/2;
            if(list[mid] == target) return (list[mid],true);
            else if(list[mid] < target)
            {
                left = mid+1;
                lessthantargetexists = true;
            } 
            else if(list[mid] > target) right = mid-1;         
        }
        int closestlower = left > right && right>=0 ? list[right] : list[mid];
        return (closestlower,lessthantargetexists);
    }
}
