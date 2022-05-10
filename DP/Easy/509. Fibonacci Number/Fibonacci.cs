public class Solution {
    Dictionary<int, int> dict = new Dictionary<int, int>();
    public Solution(){
        dict[0] = 0;
    dict[1] = 1;
    }
    
    public int Fib(int n) {
        if(dict.ContainsKey(n)){
            return dict[n];
        }

        dict[n] = Fib(n-1) + Fib(n-2);
        dict.TryGetValue(n, out var res);
        return res;
    }
}