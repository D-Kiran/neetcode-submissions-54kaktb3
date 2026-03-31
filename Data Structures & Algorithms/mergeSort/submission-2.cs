// Definition for a pair.
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
    public List<Pair> MergeSort(List<Pair> pairs) {
        return MergeAlgo(pairs,0,pairs.Count-1);
    }

    private List<Pair> MergeAlgo(List<Pair> pairs, int lo, int hi){
        if(hi<=lo) return pairs;
        int mid = lo+((hi-lo)/2);

         MergeAlgo(pairs,lo,mid);
         MergeAlgo(pairs,mid+1,hi);
         Merge(pairs,lo,mid,hi);
         return pairs;
    }

    private void Merge(List<Pair> pairs, int lo, int mid, int hi){
        Console.WriteLine($"lo - {lo} mid- {mid} hi-{hi}");
        int i = lo;
        int j=mid+1;

        var aux = new Pair[pairs.Count];

        for(int k=lo;k<=hi;k++){
            aux[k]= pairs[k];
        }

        for(int k=lo;k<=hi;k++){
            if(i > mid){
                pairs[k]=aux[j++];
            }
            else if(j>hi){
                pairs[k]=aux[i++];
            }
            else if(aux[j].Key < aux[i].Key){
                pairs[k] = aux[j++];
            }
            else{
                 pairs[k]=aux[i++];
            }
        }
    }
}
