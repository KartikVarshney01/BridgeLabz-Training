public class FirstAndLastIndex {
    public int[] SearchRange(int[] nums, int target) {
        int[] ans = new int[]{-1,-1};
        for(int i=0;i<nums.Length;i++){
            if(nums[i]==target){
                ans[0]=i;
                break;
            }
        }
        for(int j=nums.Length-1;j>=0;j--){
            if(nums[j]==target){
                ans[1]=j;
                break;
            }
        }
        return ans;
    }
}	