public class Solution {
    public bool IsValidSudoku(char[][] board) {
        var seen = new HashSet<string>();
        
        for(int i=0;i<9;i++){
            for(int j=0;j<9;j++){
                char currentVal = board[i][j];
                if(currentVal != '.'){
                    string row = currentVal + " found in row "+ i;
                    string col = currentVal + " found in col "+ j;
                    string box = currentVal + " found in sub box "+ i/3 +"-"+ j/3;

                    if(seen.Contains(row) || seen.Contains(col) || seen.Contains(box)){
                        return false;
                    }
                    seen.Add(row);
                    seen.Add(col);
                    seen.Add(box);
                }
            }
        }
        return true;
        
    }
}
