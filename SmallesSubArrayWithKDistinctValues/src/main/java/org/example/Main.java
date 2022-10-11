package org.example;

import java.util.HashMap;

class smallestSubArray {
    public static void getSmallestSubarray(int arr[], int n, int k) {
        int left = 0, right = n;
        int j = -1;
        HashMap<Integer, Integer> MAP = new HashMap<>();
        for (int i = 0; i < n; i++) {
            while (j < n - 1) {
                j++;
                if (MAP.size() < k) {
                    if (MAP.containsKey(arr[j])) MAP.put(arr[j], MAP.get(arr[j]) + 1);
                    else MAP.put(arr[j], 1);
                }
                if (MAP.size() == k && ((right - left) >= (j - i))) {
                    left = i;
                    right = j;
                    break;
                }
            }
            if (MAP.size() < k) break;
            while (MAP.size() == k) {
                if (MAP.get(arr[i]) == 1) MAP.remove(arr[i]);
                else MAP.put(arr[i], MAP.get(arr[i]) - 1);
                i++;
                if (MAP.size() == k && (right - left) >= (j - i)) {
                    left = i;
                    right = j;
                }
            }
            if (MAP.get(arr[i]) == 1) MAP.remove(arr[i]);
            else MAP.put(arr[i], MAP.get(arr[i]) - 1);
        }
        if (left == 0 && right == n) System.out.println("-1");
        else System.out.println(right);
    }

    public static void main(String[] args) {
		// https://www.tutorialcup.com/interview/hashing/smallest-subarray-with-k-distinct-numbers.htm
        // int arr[] = {1,2,2,1,2,4}; // k = 4, -1
        // int arr[] = {3,2,3,3,1,3,3}; // k= 3,  4
        int arr[] = {2,5,1,5,2,1,2,4,2,2,6}; // k= 10,  -1
        int n = arr.length;
        int k = 10;
        getSmallestSubarray(arr, n, k);
    }
}