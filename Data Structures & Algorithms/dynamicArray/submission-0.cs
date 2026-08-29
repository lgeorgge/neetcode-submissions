public class DynamicArray {
    
    private int[] arr;
    private int capacity;
    private int size = 0;

    public DynamicArray(int capacity)
    {
        if (capacity < 1) throw new Exception("cannot initialize array with size less than 1");
        arr = new int[capacity];
        this.capacity = capacity;

    }

    public int Get(int i)
    {
        return arr[i];
    }

    public void Set(int i, int n)
    {
        arr[i] = n;
    }

    public void PushBack(int n)
    {
        if (size >= capacity)
        {
            Resize();
        }
        arr[size] = n;
        size++;

    }

    public int PopBack()
    {
        if (size == 0) throw new Exception("array is empty");
        int lastElement = arr[size - 1];
        size--;
        return lastElement;
    }

    private void Resize()
    {
        int[] newArr = new int[capacity * 2];
        for (int i = 0; i < arr.Length; i++)
        {
            newArr[i] = arr[i];
        }
        arr = newArr;
        capacity *= 2;
    }

    public int GetSize()
    {
        return size;
    }

    public int GetCapacity()
    {
        return capacity;
    }
}
