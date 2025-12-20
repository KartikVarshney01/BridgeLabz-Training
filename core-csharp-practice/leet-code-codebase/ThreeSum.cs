public class ThreeSum {
    public IList<IList<int>> ThreeSum(int[] nums) {
        IList<IList<int>> ans = new List<IList<int>>();
        Array.Sort(nums);
        for(int i=0;i<nums.Length;i++){
            if(i!=0 && nums[i]==nums[i-1]) continue;
            int j = i+1;
            int k = nums.Length-1;
            while(j<k){
                int sum = nums[i]+nums[j]+nums[k];
                if(sum<0) j++;
                else if(sum>0) k--;
                else{
                    IList<int> temp = new List<int>{nums[i],nums[j],nums[k]};
                    ans.Add(temp);
                    j++;
                    k--;
                    while(j<k && nums[j]==nums[j-1]) j++;
                    while(j<k && nums[k]==nums[k+1]) k--;
                }
            } 
        }
        return ans;
    }
}