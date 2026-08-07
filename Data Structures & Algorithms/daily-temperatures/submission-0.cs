public class Solution {
    public int[] DailyTemperatures(int[] temperatures) {
         var s = new Stack<KeyValuePair<int, int>>();

        var res = new int[temperatures.Length];

        for (int i = 0; i < temperatures.Length; i++)
        {
            while(s.Count>0 && s.Peek().Value < temperatures[i])
            {
                var pair = s.Pop();
                res[pair.Key] = i - pair.Key;
            }
            s.Push(new KeyValuePair<int, int>(i, temperatures[i]));
        }

        return res;
    }
}
