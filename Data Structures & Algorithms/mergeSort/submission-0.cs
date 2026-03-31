// public class Pair {
//     public int Key;
//     public string Value;

//     public Pair(int key, string value) {
//         Key = key;
//         Value = value;
//     }
// }

public class Solution {
    // Implementation of MergeSort
    public List<Pair> MergeSort(List<Pair> pairs) {
        return MergeSortHelper(pairs, 0, pairs.Count - 1);
    }

    public List<Pair> MergeSortHelper(List<Pair> pairs, int s, int e) {
        if (e - s + 1 <= 1) {
            return pairs;
        }

        // The middle index of the array
        int m = (s + e) / 2;

        // Sort the left half
        MergeSortHelper(pairs, s, m);

        // Sort the right half
        MergeSortHelper(pairs, m + 1, e);

        // Merge sorted halves
        Merge(pairs, s, m, e);

        return pairs;
    }

    // Merge in-place
    public void Merge(List<Pair> arr, int s, int m, int e) {
        // Copy the sorted left & right halves to temp arrays
        List<Pair> L = new List<Pair>(arr.GetRange(s, m - s + 1));
        List<Pair> R = new List<Pair>(arr.GetRange(m + 1, e - m));

        int i = 0; // index for L
        int j = 0; // index for R
        int k = s; // index for arr

        // Merge the two sorted halves into the original array
        while (i < L.Count && j < R.Count) {
            if (L[i].Key <= R[j].Key) {
                arr[k] = L[i];
                i++;
            } else {
                arr[k] = R[j];
                j++;
            }
            k++;
        }

        // One of the halves will have elements remaining
        while (i < L.Count) {
            arr[k] = L[i];
            i++;
            k++;
        }
        while (j < R.Count) {
            arr[k] = R[j];
            j++;
            k++;
        }
    }
}
