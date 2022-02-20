public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        for(int i=0;i<numbers.Length-1;i++){
            int search = BinarySearch(numbers, i+1, numbers.Length-1, target-numbers[i]);
            if(search != -1){
                return new int[]{i+1, search+1};
            }
        }
        return new int[]{0,0};
    }
    
    public int BinarySearch(int[] arr, int start, int end, int num)
        {
            if(end >= start)
            {
                int mid = start + (end - start) / 2;
                if(arr[mid] == num)
                {
                    return mid;
                }
                else if(num > arr[mid])
                {
                    return BinarySearch(arr, mid + 1, end, num);
                }
                return BinarySearch(arr, start, mid-1, num);
                
            }
            return -1;
        }
}