public class CombinationSum_0039
{
    public IList<IList<int>> CombinationSum(int[] candidates, int target)
    {
        Array.Sort(candidates, (a, b) => a.CompareTo(b));
        if (candidates[0] > target)
        {
            return new List<IList<int>>();
        }

        var result = new List<IList<int>>();
        RecursiveCombinationSum(result, new List<int>(), target, candidates, 0);

        return result;
    }


    public void RecursiveCombinationSum(IList<IList<int>> result, List<int> path, int target, int[] candidates, int candidatePos)
    {
        if (target == 0)
        {
            result.Add(path.ToList());
            return;
        }

        for (int i = candidatePos; i < candidates.Length; i++)
        {
            if (candidates[i] > target)
            {
                return;
            }

            path.Add(candidates[i]);
            RecursiveCombinationSum(result, path, target - candidates[i], candidates, i);
            path.RemoveAt(path.Count - 1);
        }
    }
}