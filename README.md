# Overview
My Leetcode problem collection is to help learn **algorithms** and **data structures** through practical approach, as well as **optimize** solutions using different techniques.

## Algorithms

### Sorting Algorithms --
1. Insertoin Sort
![Video Explaination for Insertion Sort](http://img.youtube.com/vi/OGzPmgsI-pQ/0.jpg)
***
```cs
void InsertionSort(int[] arr){
  int j, temp;
  for (int i = 1, i < arr.Length; i++){
    temp = arr[i];
    j = i - 1;
    while (j >= 0 && arr[j] > temp){
      arr[j + 1] = arr[j];
      j--;
    }
    arr[j + 1] = temp;
  }
}
```
2. Selection Sort
```cs

```
3. Bubble Sort
```cs
void BubbleSort(int[] arr){
  int n = arr.Length;
  for (int i = 0; i < n-1; i++)
    // since we found the max for each turn, those positions are set without further consideration
    for (int j = 0; j < n-i-1; j++)
      if (arr[j] > arr[j + 1]){
        // Swap arr[j] and arr[j + 1]
        int temp = arr[j+1];
        arr[j+1] = arr[j];
        arr[j] = temp;
      }
}
```
4. Merge Sort
```cs

```
5. Quick Sort
```cs

```
