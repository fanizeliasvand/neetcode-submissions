public class Solution {
    public int[] DailyTemperatures(int[] temperatures) {
        var stack = new Stack<int>();
        int[] results = new int[temperatures.Length]; 
        for(int i = 0; i < temperatures.Length; i++)
        {
            while (stack.Count > 0 && temperatures[i] > temperatures[stack.Peek()])
            {
                int found = stack.Peek();
                results[found] = i - found; 
                stack.Pop();
            }
            stack.Push(i);             
        }
        return results;
        
    }
}
