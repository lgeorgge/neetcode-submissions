public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        var size = nums.Length;
        int[] leftProduct = new int[size];
        int[] rightProudct = new int[size];
        leftProduct[0] = 1;
        rightProudct[size - 1] = 1;


        for (int i = 1; i < nums.Length; i++)
        {
            leftProduct[i] = nums[i - 1] * leftProduct[i - 1];
            rightProudct[size - 1 - i] = nums[size - i] * rightProudct[size - i];
        }

        int[] result = new int[size];

        for (int i = 0; i < size; i++) result[i] = leftProduct[i] * rightProudct[i];

        return result;
    }
}
