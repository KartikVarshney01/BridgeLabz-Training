public class InsertPosSearch {
    public int SearchInsert(int[] nums, int target) {
        int index = 0;
        for(int i=0;i<nums.Length;i++){
            if(nums[i]==target) index=i;
            else if(target>nums[i]) index=i+1;
        }
        return index;
    }
}