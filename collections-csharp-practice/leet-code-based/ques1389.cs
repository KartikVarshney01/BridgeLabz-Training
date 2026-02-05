public class Solution {
    public int[] CreateTargetArray(int[] nums, int[] index) {
        int[] target = new int[nums.Length];
        int size = 0; 

        for (int i = 0; i < nums.Length; i++)
        {
            int insertPos = index[i];

            for (int j = size; j > insertPos; j--)
            {
                target[j] = target[j - 1];
            }
            target[insertPos] = nums[i];
            size++;
        }

        return target;
    }
}