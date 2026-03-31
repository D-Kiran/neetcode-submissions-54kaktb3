// Definition for a pair
// public class Pair {
//     public int Key;
//     public string Value;
//
//     public Pair(int key, string value) {
//         Key = key;
//         Value = value;
//     }
// }
public class Solution {
    public List<List<Pair>> InsertionSort(List<Pair> pairs) {

        var output = new List<List<Pair>>();
        if(pairs.Count ==0) return output;
        Clone(pairs,output);
        for(int i=1; i<pairs.Count;i++){
            for(int j=i; j>0&&pairs[j].Key<pairs[j-1].Key; j--){
               Swap(pairs,j,j-1); 
            }
            Clone(pairs, output);
        }
        return output;
    }

    private void Swap(List<Pair> pairs, int i, int j){
        var temp = pairs[i];
        pairs[i] = pairs[j];
        pairs[j]=temp;
    }

    private void Clone(List<Pair> pairs,List<List<Pair>> output){
        var tempPairs = new List<Pair>();

        foreach(var pair in pairs){
           var tempPair = new Pair(pair.Key,pair.Value);
           tempPairs.Add(tempPair);
        }
        output.Add(tempPairs);
    }
}
