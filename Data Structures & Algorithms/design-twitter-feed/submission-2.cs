public class Twitter {


    private PriorityQueue<int, int> maxheap;
    private Dictionary<int,List<int>> following ; //userid, followingpeopleid
    private Dictionary<int, List<int[]>> tweets;
    int timestamp = 0;


    public Twitter() {
        
        following = new();
        tweets = new();
    }
    
    public void PostTweet(int userId, int tweetId) {
        timestamp++;
        if(!tweets.ContainsKey(userId)){
            tweets[userId] = new List<int[]>();
        }
        tweets[userId].Add(new int[2]{tweetId,timestamp});
        
    }
    
    public List<int> GetNewsFeed(int userId) {
        maxheap = new();
        foreach(var kvp in tweets){
            if(kvp.Key == userId || (following.ContainsKey(userId) && following[userId].Contains(kvp.Key))){
                var tweetlist = tweets[kvp.Key];
                foreach(var tweet in tweetlist){
                    Console.WriteLine($"Inside the tweet list");
                    maxheap.Enqueue(tweet[0],-tweet[1]);
                }                
            }
        }

        var result = new List<int>();
        int k=10;
      
            while(maxheap.Count > 0){
                if(k == 0) break;
                result.Add(maxheap.Dequeue());
                k--;
            }
            
        return result;
    }
    
    public void Follow(int followerId, int followeeId) {
        if(!following.ContainsKey(followerId)){
            following[followerId] = new List<int>();
        }
        if(!following[followerId].Contains(followeeId))following[followerId].Add(followeeId);
    }
    
    public void Unfollow(int followerId, int followeeId) {
       if(following[followerId].Contains(followeeId)) following[followerId].Remove(followeeId);
    }
}
