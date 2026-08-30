public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        int left = 0;
        int right = numbers.Length -1;
       
        while(left < right)
        {
            int res = numbers[left] + numbers[right] ;
            if(res == target)
            {
                return new int[2]{left+1, right+1};
            }
            else if(res < target)
            {
                left ++;
            }
            else{
                right --;
            }
        }
        return new int[0];
    }
}
