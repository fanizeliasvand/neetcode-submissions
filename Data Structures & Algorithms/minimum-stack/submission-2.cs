public class MinStack {
    private Stack<int> stack;
    private Stack<int> minStack;

    public MinStack() {
        stack = new Stack <int>();
        minStack = new Stack <int>();
    }
    
    public void Push(int val) {
        stack.Push(val);
        if(minStack.Count == 0 || minStack.Peek() >= val)
        {
            minStack.Push(val);
        }
    }
    
    public void Pop() {
        if(minStack.Count != 0 && minStack.Peek() == stack.Peek()) minStack.Pop();
        stack.Pop();
    }
    
    public int Top() {
        if(stack.Count == 0) return -1;
        int top = stack.Peek();
        return top;
    }
    
    public int GetMin() {
        if(minStack.Count == 0) return -1;
        int min = minStack.Peek();
        return min;
    }
}
