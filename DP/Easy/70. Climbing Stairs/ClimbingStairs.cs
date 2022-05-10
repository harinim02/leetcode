public class Solution {
    Dictionary<int, int> dict = new Dictionary<int, int>();
    
    public Solution(){
        dict[0] = 0;
        dict[1] = 1;
        dict[2] = 2;
    }
    public int ClimbStairs(int n) {
        if(dict.ContainsKey(n)){
            return dict[n];
        }
        dict[n] = ClimbStairs(n-2)+ClimbStairs(n-1);
        return dict[n];
    }
}