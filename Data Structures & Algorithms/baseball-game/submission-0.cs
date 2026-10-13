public class Solution {
    public int CalPoints(string[] operations) {
        var stack = new Stack<int>(); 
        foreach(string s in operations)
        {
            if(s == "+" && stack.Count > 1)
            {
                int b = stack.Pop(); 
                int a = stack.Peek(); 
                stack.Push(b); 
                stack.Push(a + b); 
            }
            else if(s == "C" && stack.Count > 0) stack.Pop();
            else if(s == "D" && stack.Count > 0)
            {
                
                int a = stack.Peek(); 
                
                stack.Push(a * 2); 
            } 
            else stack.Push(int.Parse(s)); 
        }
        int res = 0; 
        while(stack.Count > 0)
        {
            res += stack.Pop(); 
        }
        return res; 
    }
}