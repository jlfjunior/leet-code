namespace LeetCode.Arrays;

public abstract class SearchInsertPosition
{
    public static int Solve(int[] nums, int target) 
        => Search(nums, 0, nums.Length -1, target);

    private static int Search(int[] nums, int low, int high, int target)
    {
        if (low > high)
            return low;

        var middle = low + (high - low) / 2;

        if (nums[middle] == target)
            return middle;

        if (target < nums[middle])
            return Search(nums, low, middle - 1, target);
        
        return Search(nums, middle + 1, high, target);
    }
}