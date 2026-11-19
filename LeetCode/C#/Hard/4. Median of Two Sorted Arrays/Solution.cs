public class Solution {
    public double FindMedianSortedArrays(int[] nums1, int[] nums2) {
        int n1 = nums1.Length;
        int n2 = nums2.Length;
        int[] arr = new int[n1 + n2];

        int i = 0, j = 0, k = 0;

        while (i < n1 && j < n2) {
            if (nums1[i] <= nums2[j]) {
                arr[k++] = nums1[i++];
            } else {
                arr[k++] = nums2[j++];
            }
        }

        while (i < n1) {
            arr[k++] = nums1[i++];
        }


        while (j < n2) {
            arr[k++] = nums2[j++];
        }

        int total = n1 + n2;
        int mid = total / 2;

        if (total % 2 == 0) {
            return (arr[mid - 1] + arr[mid]) / 2.0;
        } else {
            return arr[mid];
        }
    }
}