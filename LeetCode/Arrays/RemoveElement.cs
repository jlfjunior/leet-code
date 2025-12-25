namespace LeetCode.Arrays;

public abstract class RemoveElement
{
    public static int Solve(int[] nums, int value)
    {
        var slow = 0;

        for (var fast = 0; fast < nums.Length; fast++)
        {
            if (nums[fast] != value)
            {
                nums[slow] = nums[fast];
                slow++;
            }
        }
        
        return slow;
    }
}