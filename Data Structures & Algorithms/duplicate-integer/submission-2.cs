public class Solution {
    public bool hasDuplicate(int[] nums) {
        // [1, 2, 3, 3]
        // 1, 2, 3 --> return

        // [1, 1, 2, 3, 4]
        // 1 --> return

        var temp = new HashSet<int>();
        foreach (int number in nums) {
            if (temp.Contains(number)) {
                return true;
            }

            temp.Add(number);
        }

        return false;
    }
}