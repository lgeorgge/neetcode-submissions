public class Solution {
     List<List<int>> answer = [];
    private int[] Nums = [];

    public List<List<int>> CombinationSum(int[] nums, int target)
    {
        this.Nums = nums;
        List<int> current = [];
        Backtrack(0, current, target);
        return answer;
    }

    private void Backtrack(int index, List<int> current, int target)
    {
        if (target == 0)
        {
            answer.Add(new List<int>(current));
            return;
        }

        if (index == Nums.Length || target < 0)
        {
            return;
        }

        current.Add(Nums[index]);
        Backtrack(index, current, target - Nums[index]);
        current.RemoveAt(current.Count - 1);
        Backtrack(index + 1, current, target);
    }
}
