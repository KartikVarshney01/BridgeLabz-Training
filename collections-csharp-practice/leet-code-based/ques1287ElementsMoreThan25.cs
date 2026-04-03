public class Solution {
    public int FindSpecialInteger(int[] arr) {
        
        if (arr.Length == 0) return 0;
        if (arr.Length == 1) return arr[0];

        Dictionary<int, int> dict = new Dictionary<int, int>();

        int ans = 0;
        int percent = (int)(arr.Length*0.25);

        foreach (int n in arr)
        {
            if (dict.ContainsKey(n))
                dict[n]++;
            else
                dict[n] = 1;
        }

        foreach (int key in dict.Keys)
        {
            if (dict[key] > percent)
                return key;
        }

        return 0;
    }
}