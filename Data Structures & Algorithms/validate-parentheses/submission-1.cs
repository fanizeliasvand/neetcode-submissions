public class Solution {
    public bool IsValid(string s) {
        var stack = new Stack <char>();
        foreach(char c in s)
        {   
            if (c == '[' || c == '{' || c == '(')
            {
                stack.Push(c);
            }
            else
            {
                if (stack.Count == 0) return false; 
                char popped = stack.Pop();
                if((c == ')' && popped != '(') || (c == '}' && popped != '{') || (c == ']' && popped != '['))
                {
                    return false; 
                }
            }
        }

        return stack.Count == 0; 
    }
}
