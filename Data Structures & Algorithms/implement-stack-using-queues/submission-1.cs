public class MyStack {
    Queue<int> queue; 

    public MyStack() {
        queue = new Queue<int>(); 
    }
    
    public void Push(int x) {
        int count = queue.Count; 
        queue.Enqueue(x);
        for(int i = 0; i < count; i++)
        {
            queue.Enqueue(queue.Dequeue()); 
        }            
    }
    
    public int Pop() {
        return queue.Dequeue(); 
    }
    
    public int Top() {
        return queue.Peek(); 
    }
    
    public bool Empty() {
        return queue.Count == 0; 
        
    }
}

/**
 * Your MyStack object will be instantiated and called as such:
 * MyStack obj = new MyStack();
 * obj.Push(x);
 * int param_2 = obj.Pop();
 * int param_3 = obj.Top();
 * bool param_4 = obj.Empty();
 */