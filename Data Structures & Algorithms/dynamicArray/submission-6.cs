public class DynamicArray {

    private int count;
    private int capacity;
    private int[] array;

    public DynamicArray(int capacity) {
        this.count = 0;
        this.capacity = capacity;
        this.array = new int[capacity];
    }

    public int Get(int i) {
        return array[i];
    }

    public void Set(int i, int n) {
        array[i]=n;
    }

    public void PushBack(int n) {
        if(count == capacity){
            Resize();
        }
        array[count]=n;
        count++;
    }

    public int PopBack() {
        count--;
        return array[count];
    }

    private void Resize() {
        this.capacity *=2;
        var newArray = new int[this.capacity];

        for(int i=0;i<array.Length;i++){
            newArray[i]=array[i];
        }
        array = newArray;
    }

    public int GetSize() {
        return count;
    }

    public int GetCapacity() {
        return capacity;
    }
}
