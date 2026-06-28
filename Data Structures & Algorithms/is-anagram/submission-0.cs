public class Solution {
    public bool IsAnagram(string s, string t) {
        // s = jar, t = jam
        // --> false

        // s = racecar, t = carrace
        // --> true

        if (s.Length != t.Length)
            return false;

        var charsCount = new Dictionary<char, int>();
        foreach (char c in s) {
            charsCount.TryGetValue(c, out int count);
            charsCount[c] = ++count;
        }

        foreach (char c in t) {
            charsCount.TryGetValue(c, out int count);

            if (count == 0)
                return false;

            charsCount[c] = --count;
        }

        return true;
    }
}