public class ContainsMostWater {
    public int MaxArea(int[] height) {
        int left = 0;
        int right = height.Length-1;
        int max = int.MinValue;
        while(left<right){
            // int width = right - left;
            // int h = Math.Min(height[left],height[right]);
            // int area = Math.Max(max,area);
            max = Math.Max(max,(right-left)*Math.Min(height[left],height[right]));
            if(height[left]<height[right]) left++;
            else right--;
        }
        return max;
    }
}