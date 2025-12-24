namespace LeetCode.Arrays;

public abstract class TwoSum
{
    public static int[] Solve(int[] nums, int target, Technique  technique)
    {
        return technique switch
        {
            Technique.HashMap => HashMap(nums, target),
            Technique.BruteForce => BruteForce(nums, target),
            _ => throw new NotImplementedException()
        };
    }

    private static int[] HashMap(int[] nums, int target)
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
    
    private static int[] BruteForce(int[] nums, int target)
    {
        for (var i = 0; i < nums.Length; i++)
            for (var j = i+1; j < nums.Length; j++)
                if (nums[i] + nums[j] == target)
                    return [i, j];
        
        throw new ArgumentOutOfRangeException();
    }
}