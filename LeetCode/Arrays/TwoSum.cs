namespace LeetCode.Arrays;

public abstract class TwoSum
{
    public static int[] Solve(int[] nums, int target)
    {
        var map = new Dictionary<int, int>();

        for (var i = 0; i < nums.Length; i++)
        {
            var complement = target - nums[i];
            
            if (map.TryGetValue(complement, out var index))
                return [index, i ];
            
            if (!map.ContainsKey(nums[i]))
                map[nums[i]] = i;
        }
        
        throw new ArgumentOutOfRangeException();
    }
}