public class Solution {
    public int EvalRPN(string[] tokens) {
        var stack = new Stack <int>();
        foreach(string token in tokens)
        {
            if(token == "+" || token == "*" || token == "-" || token == "/")
            {
                int right = stack.Pop();
                int left = stack.Pop();
                if (token == "+") stack.Push(left + right);
                if (token == "-") stack.Push(left - right);
                if (token == "*") stack.Push(left * right);
                if (token == "/") stack.Push(left / right);
            }
            else stack.Push(int.Parse(token));
        }
        return(stack.Pop());
        
    }
}
