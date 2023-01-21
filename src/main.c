#include <stdio.h>
#include "search_functions.h"

int main()
{
    int arr[] = { 2, 3, 5, 8, 12, 16 };
    int n = sizeof(arr) / sizeof(arr[0]);
    int x = 16;

    int result = recursiveBinarySearch(arr, 0, n-1, x);

    (result == -1) ? printf("Element is not present in array") : printf("Element is present at index %d", result);

    return 0;
}
