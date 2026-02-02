public class Solution {
    public int[] ReplaceElements(int[] arr) {
        int max = arr[arr.Length-1];
        for(int i=arr.Length-1;i>=0;i--){
            if(i==arr.Length-1){
                arr[i] = -1;
            }
            else{
                int temp = arr[i];
                arr[i] = max;
                if(temp>max) max = temp;
            }
        }
        return arr;
    }
}