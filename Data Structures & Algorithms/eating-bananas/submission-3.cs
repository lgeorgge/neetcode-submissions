public class Solution {
    public int MinEatingSpeed(int[] piles, int h) {
        int max = piles.Max();
        int min = 1;

        int bestSoFar = max;

        while (min <= max)
        {
            int m = min + (max - min) / 2;

            long current = 0;
            foreach (int b in piles)
            {
                current += (b + m - 1L) / m;
            }

            if (current > h)
            {
                min = m + 1;
            }
            else
            {
                bestSoFar = m;
                max = m - 1;
            }
        }

        return bestSoFar;
    }
}