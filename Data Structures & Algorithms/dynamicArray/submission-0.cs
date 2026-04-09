public class DynamicArray {
    private int[] arr;
    private int capacity = 0;
    private int size = 0;
    
    public DynamicArray(int capacity) {
        this.capacity = capacity;
        arr = new int [capacity];
    }

    public int Get(int i) {
        return arr[i];
    }

    public void Set(int i, int n) {
        arr[i] = n;
    }

    public void PushBack(int n) {
        if (size == capacity)
        {
            Resize();
        }
        arr[size] = n;
        size ++;
        
    }

    public int PopBack() {
        int value = arr[size - 1];
        size--;
        return value;
    }

    private void Resize() {
        capacity *= 2;
        int[] newarr = new int [capacity];
        for(int i = 0; i < size; i++)
        {
            newarr[i] = arr[i];
        }
        arr = newarr;

    }

    public int GetSize() {
        return size;

    }

    public int GetCapacity() {
        return capacity;

    }
}
