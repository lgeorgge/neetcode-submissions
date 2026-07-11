class Solution:
    def topKFrequent(self, nums: List[int], k: int) -> List[int]:
        m = {}
        for i in nums:
            if i in m:
                m[i] = m[i] + 1
            else:
                m[i] = 1

        m = sorted(m.items(), key=lambda x: x[1], reverse=True)
        return [i[0] for i in m[:k]]
        