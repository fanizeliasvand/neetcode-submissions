public class Solution
{
    public List<List<int>> CombinationSum(int[] candidates, int target)
    {
        var res = new List<List<int>>();
        int sum = 0;

        Backtrack(candidates, target, res, new List<int>(), sum, 0);

        return res;
    }

    private void Backtrack(
        int[] candidates,
        int target,
        List<List<int>> res,
        List<int> path,
        int sum,
        int index)
    {
        if (sum == target)
        {
            res.Add(new List<int>(path));
            return;
        }

        if (sum > target) return;

        for (int i = index; i < candidates.Length; i++)
        {
            sum += candidates[i];
            path.Add(candidates[i]);

            Backtrack(candidates, target, res, path, sum, i);

            path.RemoveAt(path.Count - 1);
            sum -= candidates[i];
        }
    }
}