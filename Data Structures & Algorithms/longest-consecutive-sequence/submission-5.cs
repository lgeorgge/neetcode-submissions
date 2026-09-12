public class Solution {
    public int LongestConsecutive(int[] nums) {
        var set = nums.ToHashSet();
        int longestStreak = 0;
        foreach (var n in set)
        {
            if (!set.Contains(n - 1))
            {
                int currentStreak = 1;
                while (set.Contains(n + currentStreak))
                {
                    currentStreak++;
                }
                longestStreak = Math.Max(longestStreak, currentStreak);
            }
        }
        return longestStreak;
    }
}
