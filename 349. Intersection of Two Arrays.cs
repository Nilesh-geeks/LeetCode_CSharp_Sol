Question ::349. Intersection of Two Arrays

Given two integer arrays nums1 and nums2, return an array of their intersection. Each element in the result must be unique and you may return the result in any order.
 
Solution::
Complexity
Time complexity:
    O(N)
Space complexity:
    O(N)

Code::
public class Solution {
    public int[] Intersection(int[] nums1, int[] nums2) {
HashSet<int>s = new HashSet<int>(nums1);
HashSet<int>s2 = new HashSet<int>(nums2);
s.IntersectWith(s2);
return s.ToArray();
    }
}