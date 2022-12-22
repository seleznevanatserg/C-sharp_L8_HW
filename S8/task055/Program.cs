/* Задача 55: Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. 
В случае, если это невозможно, программа должна вывести сообщение для пользователя. */

using static UserMethods.Method;

int[,] genArray = GeneratedRandom2dArray();
Print2dGenArray(genArray);
Console.WriteLine();
int[,] reversArray = reversedRowsToColunms(genArray);
Print2dGenArray(reversArray);



int[,] reversedRowsToColunms(int[,] array)
{
    int[,] revArray = new int[genArray.GetLength(0), genArray.GetLength(1)];
    if (array.GetLength(0) != array.GetLength(1))
    {
        Console.WriteLine("Error. This matrix not squared.");
    }
    else
        for (int i = 0; i < array.GetLength(1); i++)
        {
            for (int j = 0; j < array.GetLength(0); j++)
            {
                revArray[i, j] = array[j, i];
            }
        }
    return revArray;
}

// Генерация массива с раномными строками/столбцами и значениями
int[,] GeneratedRandom2dArray()
{
    Random rnd = new Random();
    int rows = InputIntNumberTryParse();
    while (rows < 0) // отсеивание значений < 0 для строки, пока юзер нормально не введёт.
    {
        Console.WriteLine($"Entered unacceptable number for ROW. Need number > 0");
        rows = InputIntNumberTryParse();
    }
    int columns = InputIntNumberTryParse();
    while (columns < 0) // отсеивание значений < 0 для строки, пока юзер нормально не введёт.
    {
        Console.WriteLine($"Entered unacceptable number for COLUMN. Need number > 0");
        columns = InputIntNumberTryParse();
    }
    int[,] array = new int[rows, columns];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(-20, 21);
        }
    }
    return array;
}
// Печать массива
void Print2dGenArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"[{array[i, j]}]" + "\t");
        }
        Console.WriteLine();
    }
}