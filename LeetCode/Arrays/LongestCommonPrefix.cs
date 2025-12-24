using System.Text;

namespace LeetCode.Arrays;

public abstract class LongestCommonPrefix
{
    public static string Solve(string[] strs)
    {
        if (strs == null || strs.Length == 0)
            return string.Empty;

        var first = strs[0];
        var prefix = new StringBuilder();

        for (var i = 0; i < first.Length; i++)
        {
            var currentChar = first[i];

            foreach (var s in strs)
            {
                if (i >= s.Length || s[i] != currentChar)
                    return prefix.ToString();
            }

            prefix.Append(currentChar);
        }

        return prefix.ToString();
    }
}