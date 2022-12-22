/* Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07 */

using static UserMethods.Method;
Random rnd = new Random();

int[,] array = SpiralArray();
Print2dGenArray(array);

int[,] SpiralArray()
{
    int[,] arr = new int[4, 4];
    int count = 1;
    int col = 3;
    int row = 0;
    while (count < 16)
    {
        // right
        for (int r = 0+col; r < 4-col; r++)
        {
            arr[row, r] = count;
            count++;
        }

        // down
        for (int d = col; d < 4; d++)
        {
            arr[d, 3] = count;
            count++;
        }
        // left
        for (int l = 3; l > 0; l--)
        {
            arr[3, l] = count;
            count++;
        }
        // up
        for (int u = 3; u > 0; u--)
        {
            arr[u, 3] = count;
            count++;
        }
        

    }
    return arr;
}


/*  int count = 1;
 int limitRow = arr.GetLength(0);
 int limitColumn = arr.GetLength(1);
 int startRow = 0;
 int startColumn = 0;
 while (count < arr.GetLength(0) * arr.GetLength(1))
 {
    // right
    for (int r = startColumn; r < limitColumn; r++)
     {
         arr[startRow, r] = count;
         count++;
     }
     startRow++;

      // down
     for (int d = startRow; d < limitRow; d++)
     {
         arr[d, limitColumn] = count;
         count++;
     }
     limitColumn--; 

     // left
     for (int l = limitColumn; l > startRow; l--)
     {
         arr[limitRow, l] = count;
         count++;
     }
     limitRow--;

     // up
     for (int u = limitRow; u > startRow; u--)
     {
         arr[u, limitColumn] = count;
         count++;
     }
     startColumn--; 
 } */

