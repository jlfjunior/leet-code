using LeetCode.Arrays;

namespace LeetCode.Tests;

public class LongestCommonPrefixTests
{
    [Theory]
    [InlineData(new []{"flower","flow","flight"}, "fl")]

    [InlineData(new []{"dog","racecar","car"}, "")]

    public void LongestCommonPrefix_Should_Return_Correct_Indexes(string[] strs, string expected)
    {
        var result = LongestCommonPrefix.Solve(strs);
        
        Assert.Equal(expected, result);
    }
}