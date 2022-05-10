public class Solution {
    Dictionary<int, int> dict = new Dictionary<int, int>();
    public Solution(){
        dict[0] = 0;
        dict[1] = dict[2] = 1;
    }
    public int Tribonacci(int n) {
        if(dict.ContainsKey(n)){
            return dict[n];
        }
        dict[n] = Tribonacci(n-3) + Tribonacci(n-2) + Tribonacci(n-1);
        dict.TryGetValue(n, out var result);
        return result;
    }
}