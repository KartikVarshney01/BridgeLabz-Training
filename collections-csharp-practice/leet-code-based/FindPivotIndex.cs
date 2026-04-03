public class Solution {
    public int PivotIndex(int[] nums) {
        int sumRight = 0;
        foreach(int num in nums) sumRight += num;
        int sumLeft = 0;
        for(int i=0;i<nums.Length;i++){
            sumRight -= nums[i];
            if(sumLeft == sumRight) return i;
            sumLeft += nums[i];
        }
        return -1;
    }
}