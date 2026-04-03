public class Solution {
    public int FindKthPositive(int[] arr, int k) {
        int missingCount = 0;
        int current = 1;
        int i = 0;

        while (missingCount < k)
        {
            if (i < arr.Length && arr[i] == current)
            {
                i++;
            }
            else
            {
                missingCount++;
            }
            current++;
        }

        return current - 1;
    }
}