using LeetCode.Arrays;

namespace LeetCode.Tests;

public class RemoveElementTests
{
    [Theory]
    [InlineData(new []{3,2,2,3}, 3, 2)]

    [InlineData(new []{0,1,2,2,3,0,4,2}, 2,5)]

    public void RemoveElement_Should_Return_Correct_Indexes(int[] nums, int value, int expected)
    {
        var result = RemoveElement.Solve(nums, value);
        
        Assert.Equal(expected, result);
    }
}