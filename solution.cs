public class Solution {
    private bool hasZero(int n){
        while(n > 0){
            if(n % 10 == 0) return true;
            n = n / 10;
        }
        return false;
    }
    
    public int[] GetNoZeroIntegers(int n) {
        int r = n - 1;
        for(int i = 1; i <= n / 2; i++){
            if(!hasZero(i) && !hasZero(r)){
                return(new int[] {i, r});
            }

            r--;
        }
        return(null);
    }
}
