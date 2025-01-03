public class RotateString_0796
{
    public bool RotateString(string s, string goal)
    {
        if (s.Length != goal.Length) return false;
        return (s + s).Contains(goal);
    }
}