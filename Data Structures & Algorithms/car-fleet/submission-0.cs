public class Solution {
    public int CarFleet(int target, int[] position, int[] speed) {
         var pairs = position.Zip(speed, (p, s) => new KeyValuePair<int, int>(p, s)).OrderByDescending(p => p.Key).ToList();
        var stack = new Stack<double>();
        foreach (var pair in pairs)
        {
            var time = (double)(target - pair.Key) / pair.Value;
            if (stack.Count == 0 || time > stack.Peek())
            {
                stack.Push(time);
            }
        }
        return stack.Count;
    }
}
