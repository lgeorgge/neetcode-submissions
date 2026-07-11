class Solution:
    def twoSum(self, nums: List[int], target: int) -> List[int]:
        prev_map = {}
        for index, val in enumerate(nums):
            diff = target - val
            if diff in prev_map:
                return [prev_map[diff], index]
            prev_map[val] = index



