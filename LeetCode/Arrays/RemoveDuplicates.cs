namespace LeetCode.Arrays;

public abstract class RemoveDuplicates
{
    public static int Solve(int[] nums)
    {
        var slow = 1;

        for (var fast = 1; fast < nums.Length; fast++)
        {
            if (nums[fast] != nums[fast - 1])
            {
                nums[slow] = nums[fast];
                slow++;
            }
        }
        
        return slow;
    }
}