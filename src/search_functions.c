#include <stdio.h>

int linearSearch(int arr[], int N, int x)
{
    for(int i = 0; i < N; i++)
        if(arr[i] == x)
            return i;

    return -1;
}

int recursiveBinarySearch(int arr[], int l, int r, int x)
{
    //verify index before start algorithm
    if (r >= l)
    {
        // calculate midpoint of array by adding half of the difference between left and right to left
        // getting the difference (r - l) is needed to not cause an int overflow whether right is near to the maximum int possible
        int mid = l + (r - l) / 2;
        
        // if midpoint contains the element just return it
        if (arr[mid] == x)
            return mid;

        // if midpoint value is greater, the element calls the function again redefining the maximum index to the midpoint
        if (arr[mid] > x)
            return recursiveBinarySearch(arr, l, mid - 1, x);

        // if midpoint value is less, the element calls the function again redefining the minimum index to the midpoint    
        return recursiveBinarySearch(arr, mid + 1, r, x);
    }

    // the element is not in the array
    return -1;
}

int binarySearch(int arr[], int l, int r, int x)
{
    while (r >= l) 
    {
        int mid = l + (r - l) / 2;

        if (arr[mid] == x)
            return mid;

        if (arr[mid] > x) 
            r = mid - 1;
        else
            l = mid + 1;
    }

    return -1;
}