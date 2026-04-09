public class Solution {
    public int CarFleet(int target, int[] position, int[] speed) {
        var cars = new List<(int pos, double time)>();
        for(int i = 0; i < position.Length; i++)
        {
            double time = (double)(target - position[i]) / speed[i];
            cars.Add((position[i], time));
        }
        cars.Sort((a, b) => a.pos.CompareTo(b.pos));
        int fleets = 0; 
        double lastTime = 0; 
        for(int i = position.Length - 1; i >= 0; i--)
        {
            double currentTime = cars[i].time;
            if(currentTime > lastTime)
            {
                fleets++;
                lastTime = currentTime; 
            }
        }
        return fleets; 
    }
}
