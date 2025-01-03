public class IsomorphicStrings_0205
{
    public bool IsIsomorphic(string s, string t)
    {
        if (s.Length != t.Length)
        {
            return false;
        }

        var charMapStoT = new int[256]; // ASCII only
        var charMapTtoS = new int[256];

        for (int i = 0; i < s.Length; i++)
        {
            int charS = s[i];
            int charT = t[i];

            if (charMapStoT[charS] == 0 && charMapTtoS[charT] == 0)
            {
                charMapStoT[charS] = charT;
                charMapTtoS[charT] = charS;
            }
            else if (charMapStoT[charS] != charT || charMapTtoS[charT] != charS)
            {
                return false;
            }
        }

        return true;
    }
}