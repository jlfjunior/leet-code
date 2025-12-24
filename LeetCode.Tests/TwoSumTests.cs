using LeetCode.Arrays;

namespace LeetCode.Tests;

public class TwoSumTests
{
    [Theory]
    [InlineData(new []{2, 7, 11, 15}, 9, new[] {0, 1})]

    [InlineData(new []{3, 3}, 6, new[] { 0,1})]

    public void TwoSum_Should_Return_Correct_Indexes(int[] nums, int target, int[] expected)
    {
        var result = TwoSum.Solve(nums, target);
        
        Assert.Equal(expected, result);
    }
}