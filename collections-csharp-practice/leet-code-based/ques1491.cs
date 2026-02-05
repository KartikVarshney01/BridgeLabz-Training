public class Solution {
    public double Average(int[] salary) {
        int min = salary[0];
        int max = salary[0];
        int totalsum = 0;
        foreach(int sal in salary){
            totalsum += sal;
            if(sal<min) min = sal;
            if(sal>max) max = sal;
        }
        totalsum -= (min+max);
        return (double)totalsum/(salary.Length-2);
    }
}