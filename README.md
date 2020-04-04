# Overview
My Leetcode problem collection is to help learn **algorithms** and **data structures** through practical approach, as well as **optimize** solutions using different techniques.

## Algorithms

### Sorting Algorithms --
#### Insertoin Sort

#### Selection Sort

#### Bubble Sort
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
#### Merge Sort

#### Quick Sort
