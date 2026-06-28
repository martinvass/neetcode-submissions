public class Solution {
    public bool hasDuplicate(int[] nums) {
        // [1, 2, 3, 3]
        // 1, 2, 3 --> return

        // [1, 1, 2, 3, 4]
        // 1 --> return

        var seen = new HashSet<int>();
        foreach (int n in nums)
            if (!seen.Add(n)) return true;
        
        return false;
    }
}