Question :: 3005. Count Elements With Maximum Frequency

You are given an array nums consisting of positive integers.

Return the total frequencies of elements in nums such that those elements all have the maximum frequency.

The frequency of an element is the number of occurrences of that element in the array.

Solution::
Complexity
Time complexity:
    O(N)
Space complexity:
    O(N)

Code::
public class Solution {
    public int MaxFrequencyElements(int[] nums) {
        Dictionary<int , int > map = new Dictionary<int,int>();
        foreach(int val in nums){
            if(!map.ContainsKey(val))
               map[val] =0;
            map[val]++;
        }
        int maxi =0 ;
        int cnt =0 ;
        foreach(var i in map){
            maxi = System.Math.Max(maxi , i.Value);
        }
        foreach(var i in map){
            if(i.Value == maxi)cnt+=i.Value;
        }
     return cnt;
    }
}