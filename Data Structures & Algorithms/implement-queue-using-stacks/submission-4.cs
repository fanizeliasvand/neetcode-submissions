public class MyQueue {
    public Stack<int> stack; 
    public Stack<int> reversed; 
    public MyQueue() {
        reversed = new Stack<int>(); 
        stack = new Stack<int>(); 
    }
    
    public void Push(int x) {
        stack.Push(x);
    }
    
    public int Pop() {
        if(reversed.Count == 0)
        {
            while(stack.Count > 0)
            {
                reversed.Push(stack.Pop()); 
            }
        }
        return reversed.Pop(); 
    }
    
    public int Peek() {
        if(reversed.Count == 0)
        {
            while(stack.Count > 0)
            {
                reversed.Push(stack.Pop()); 
            }
        } 
        return reversed.Peek(); 
    }
    
    public bool Empty() {
        if(stack.Count == 0 && reversed.Count == 0) return true; 
        return false; 
    }   
}

/**
 * Your MyQueue object will be instantiated and called as such:
 * MyQueue obj = new MyQueue();
 * obj.Push(x);
 * int param_2 = obj.Pop();
 * int param_3 = obj.Peek();
 * bool param_4 = obj.Empty();
 */