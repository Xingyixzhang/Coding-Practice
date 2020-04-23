**[Reference: BSC Data Structures](http://www.btechsmartclass.com/data_structures/sparse-matrix.html)**
# Overview of Sparse Matrix
## Definition:
#### *Sparse Matrix is a matrix which contains very few non-zero elements.*
## Sparse Matrix Representations:
### 1. Triplet Representation (Array)
![Triplet Representation of Sparse Matrix](http://www.btechsmartclass.com/data_structures/ds_images/Triplet_Representation_of_Sparse_Matrix.png "Triplet Representation")
#### *Implementation of Array Representation of Sparse Matrix in C++:*
```cpp
#include<iostream>

using namespace std;

int main()
{
    // sparse matrix of class 5x6 with 6 non-zero values
    int sparseMatrix[5][6] =
    {
        {0 , 0 , 0 , 0 , 9, 0 },
        {0 , 8 , 0 , 0 , 0, 0 },
        {4 , 0 , 0 , 2 , 0, 0 },
        {0 , 0 , 0 , 0 , 0, 5 },
        {0 , 0 , 2 , 0 , 0, 0 }
    };

    // Finding total non-zero values in the sparse matrix
    int size = 0;
    for (int row = 0; row < 5; row++)
        for (int column = 0; column < 6; column++)
            if (sparseMatrix[row][column] != 0)
                size++;

    // Defining result Matrix
    int resultMatrix[3][size];

    // Generating result matrix
    int k = 0;
    for (int row = 0; row < 5; row++)
        for (int column = 0; column < 6; column++)
            if (sparseMatrix[row][column] != 0)
            {
                resultMatrix[0][k] = row;
                resultMatrix[1][k] = column;
                resultMatrix[2][k] = sparseMatrix[row][column];
                k++;
            }

    // Displaying result matrix
    cout<<"Triplet Representation : "<<endl;
    for (int row=0; row<3; row++)
    {
        for (int column = 0; column<size; column++)
            cout<<resultMatrix[row][column]<<" ";

        cout<<endl;
    }
    return 0;
}
```
#### *Output*:
![C++ Code Output](http://www.btechsmartclass.com/data_structures/ds_images/Sparse_Matrix_Program.png)
### 2. Linked Representation
 *Use linked list to represent a sparse matrix by **header node** and **element node** *
 
 ![header Node and Element Node](http://www.btechsmartclass.com/data_structures/ds_images/Linked_Representation_Nodes.png)
 
 ![Linked Representation of Sparse Matrix](http://www.btechsmartclass.com/data_structures/ds_images/Linked_Representation_of_Sparse_Matrix.png)
 
 
