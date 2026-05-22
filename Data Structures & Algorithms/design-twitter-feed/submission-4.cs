public class Twitter {

    int count;
    private Dictionary<int,HashSet<int>> followmap;
    private Dictionary<int,List<int[]>> tweetmap;

    public Twitter() {
        count =0;
        followmap = new();
        tweetmap = new();
    }
    
    public void PostTweet(int userId, int tweetId) {
        count++;
        if(!tweetmap.ContainsKey(userId)){
            tweetmap[userId] = new List<int[]>();
        }

        tweetmap[userId].Add(new int[2]{count,tweetId});
    }
    
    public List<int> GetNewsFeed(int userId) {
        List<int> result = new();

        PriorityQueue<int[],int> maxheap = new();

        //user always follows himself so as to get the feed
       if(!followmap.ContainsKey(userId)){
            followmap[userId] = new HashSet<int>();
        }

        followmap[userId].Add(userId);

        foreach(var followeeid in followmap[userId]){
            if(tweetmap.ContainsKey(followeeid) && tweetmap[followeeid].Count >0){
                List<int[]> tweets = tweetmap[followeeid];
                int index = tweets.Count-1;
                int[] latesttweet = tweets[index];

                maxheap.Enqueue(new int[]{latesttweet[0], latesttweet[1], followeeid,index}, -latesttweet[0]);
            }
        }

        while(maxheap.Count >0 && result.Count < 10){
            int[] current = maxheap.Dequeue();
            result.Add(current[1]);

            int index = current[3];
            if(index > 0){
                int[] tweet = tweetmap[current[2]][index-1];
                maxheap.Enqueue(new int[]{tweet[0], tweet[1],current[2],index-1}, -tweet[0]);
            }
        }

        return result;
    }
    
    public void Follow(int followerId, int followeeId) {
        if(!followmap.ContainsKey(followerId)){
            followmap[followerId] = new HashSet<int>();
        }

        followmap[followerId].Add(followeeId);
    }
    
    public void Unfollow(int followerId, int followeeId) {
          if(followmap.ContainsKey(followerId)){
            followmap[followerId].Remove(followeeId);
        }

        
    }
}
