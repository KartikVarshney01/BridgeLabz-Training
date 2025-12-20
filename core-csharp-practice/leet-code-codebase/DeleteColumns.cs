public class DeleteColumns {
    public int MinDeletionSize(string[] strs) {
        int count = 0;
        int row = strs.Length;
        int col = strs[0].Length;
        for(int i=0;i<col;i++){ // col wise
            for(int j=0;j<row-1;j++){ // row wise 
                if(strs[j][i]>strs[j+1][i]){
                    count++;
                    break;
                }
            }
        }
        return count;
    }
}