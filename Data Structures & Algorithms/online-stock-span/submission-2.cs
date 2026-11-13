public class StockSpanner {
    public Stack<(int price, int count)> stack; 

    public StockSpanner() {
        stack = new Stack<(int price, int count)>(); 
    }
    
    public int Next(int price) {
        int count = 1; 
        while(stack.Count > 0 && price >= stack.Peek().price)
        {
            var popped = stack.Pop(); 
            count += popped.count; 
        }
        stack.Push((price, count)); 
        return count; 
    }
}

/**
 * Your StockSpanner object will be instantiated and called as such:
 * StockSpanner obj = new StockSpanner();
 * int param_1 = obj.Next(price);
 */