public class Solution {
      private string normalize(string word)
    {
        var r = word.ToCharArray();
        Array.Sort(r);
        return string.Concat(r);
    }
    public List<List<string>> GroupAnagrams(string[] strs) {
        Dictionary<string, List<string>> angrams = [];

        foreach (var s in strs)
        {
            var norm = normalize(s);
            if (angrams.ContainsKey(norm))
            {
                angrams[norm].Add(s);
            }
            else
            {
                angrams.Add(norm, new List<string>() { s });
            }
        }

        return [.. angrams.Values];
    }
}
