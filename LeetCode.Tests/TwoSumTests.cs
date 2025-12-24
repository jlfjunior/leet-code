using LeetCode.Arrays;

namespace LeetCode.Tests;

public class TwoSumTests
{
    [Theory]
    [InlineData(new []{2, 7, 11, 15}, 9, new[] {0, 1}, Technique.HashMap)]
    [InlineData(new []{2, 7, 11, 15}, 9, new[] {0, 1}, Technique.BruteForce)]
    [InlineData(new []{3, 3}, 6, new[] { 0,1}, Technique.HashMap)]
    [InlineData(new []{3, 3}, 6, new[] { 0,1}, Technique.BruteForce)]
    public void TwoSum_Should_Return_Correct_Indexes(int[] nums, int target, int[] expected, Technique technique)
    {
        var result = TwoSum.Solve(nums, target, technique);
        
        Assert.Equal(expected, result);
    }
}