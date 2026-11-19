public class Solution {
    public double FindMedianSortedArrays(int[] nums1, int[] nums2) {
        int n1 = nums1.Length;
        int n2 = nums2.Length;

        int[] arr = new int[n1+n2];

        int i = 0;
        int j = 0;
        int k = 0;

        while(k < arr.Length){
            if(nums1[i] < nums2[j]){
                arr[k] = nums1[i];
                if(i == n1-1){
                    nums1[i] = Int32.MaxValue;
                }else{i++;}
            }
            else{
                arr[k] = nums2[j];
                if(j == n2-1){
                    nums2[j] = Int32.MaxValue;
                }else{j++;}
            }
            k++;
        }
        int x = arr.Length/2;
        if(arr.Length % 2 == 0){
            return (double)(arr[x] + arr[x-1]) / 2;
        }
        else{
            return (double)arr[x];
        }
    }
}
