using LeetCode.Arrays;

namespace LeetCode.Tests;

public class SearchInsertPositionTests
{
    [Theory]
    [InlineData(new []{1,3,5,6}, 5, 2)]

    [InlineData(new []{1,3,5,6}, 2,1)]
    [InlineData(new []{1,3,5,6}, 7,4)]

    public void SearchInsert_Should_Return_Correct_Index(int[] nums, int target, int expected)
    {
        var result = SearchInsertPosition.Solve(nums, target);
        
        Assert.Equal(expected, result);
    }
}