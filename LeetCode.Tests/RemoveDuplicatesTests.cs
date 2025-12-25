using LeetCode.Arrays;

namespace LeetCode.Tests;

public class RemoveDuplicatesTests
{
    [Theory]
    [InlineData(new []{1,1,2}, 2)]

    [InlineData(new []{0,0,1,1,1,2,2,3,3,4}, 5)]

    public void RemoveDuplicates_Should_Return_Correct_Indexes(int[] nums, int expected)
    {
        var result = RemoveDuplicates.Solve(nums);
        
        Assert.Equal(expected, result);
    }
}