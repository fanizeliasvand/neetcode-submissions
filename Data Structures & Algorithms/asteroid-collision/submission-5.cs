public class Solution {
    public int[] AsteroidCollision(int[] asteroids) {
        Stack<int> stack = new Stack<int>(); 
        foreach(int asteroid in asteroids)
        {
            bool alive = true; 
            while(stack.Count > 0 && stack.Peek() > 0 && asteroid < 0)
            {
                if(stack.Peek() + asteroid == 0) 
                {
                    stack.Pop(); 
                    alive = false; 
                    break; 
                }
                else if (stack.Peek() < -asteroid)
                {
                    stack.Pop(); 
                }
                else 
                {
                    alive = false; 
                    break; 
                }
            }
            if(alive) stack.Push(asteroid);
        }
        int count = stack.Count; 
        int[] res = new int[count]; 
        for(int i = count - 1; i >= 0; i--)
        {
            res[i] = stack.Pop(); 
        }
        return res; 
    }
}