class Solution:
    def isAnagram(self, s: str, t: str) -> bool:
        a1 = sorted(s)
        a2 = sorted(t)
        return a1 == a2