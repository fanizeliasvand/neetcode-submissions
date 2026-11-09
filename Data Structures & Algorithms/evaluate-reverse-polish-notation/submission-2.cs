public class Solution {
    public int EvalRPN(string[] tokens) {
        Stack<int> stack = new Stack<int>(); 
        foreach(string c in tokens)
        {
            if(c == "+" || c == "-" || c == "/" || c == "*")
            {
                if(stack.Count > 1)
                {
                    int b = stack.Pop(); 
                    int a = stack.Pop(); 
                    if(c == "+")
                    {
                        stack.Push(a + b); 
                    }
                    else if(c == "-")
                    {
                        stack.Push(a - b); 
                    }
                    else if(c == "*")
                    {
                        stack.Push(a * b); 
                    }
                    else if(c == "/")
                    {
                        stack.Push(a / b); 
                    }

                }
            }
            else 
            {
                stack.Push(int.Parse(c)); 
            }
        }
        return stack.Peek(); 
    }
}
