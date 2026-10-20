public class Solution {
    public int LengthOfLongestSubstring(string s) {
 HashSet<char> seen = [];
        int left = 0;
        int maxLength = 0;
        for (int right = 0; right < s.Length; right++)
        {
            if (!seen.Contains(s[right]))
            {
                seen.Add(s[right]);
                maxLength = Math.Max(maxLength, right - left + 1);
            }
            else
            {
               while (s[left] != s[right])
                {
                    seen.Remove(s[left]);
                    left++;
                }
                left++;
            }
        }

        return maxLength;
    }
}
