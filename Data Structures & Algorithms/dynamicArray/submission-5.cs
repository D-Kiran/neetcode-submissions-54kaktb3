public class DynamicArray {
    
    private int Length;
    private int[] Array;
    private int Count =0;

    public DynamicArray(int capacity) {
        Length = capacity;
        Count =0;

        Array = new int[capacity];
    }

    public int Get(int i) {
        return Array[i];
    }

    public void Set(int i, int n) {
        Array[i]=n;
        //Count++;
    }

    public void PushBack(int n) {
        if(Count == Length){
            Resize();
        }
        // for(int i=1;i<Length;i++){
        //     Array[i-1]=Array[i];
        // }
        Array[Count]=n;
        Count++;
    }

    public int PopBack() {
      
            // soft delete the last element
           Count--;
        
        
        return Array[Count];

    }

    private void Resize() {

        var newArray = new int[2*Length];

        for(int i=0; i<Array.Length;i++){
            newArray[i]=Array[i];
        }
        Length=2*Length;
        Array = newArray;
    }

    public int GetSize() {
        return Count;
    }

    public int GetCapacity() {
        return Length;
    }
}
