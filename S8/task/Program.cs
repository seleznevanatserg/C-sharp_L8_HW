/* Задача 53: Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива. */



int [,] genArray = GeneratedRandom2dArray();
Print2dGenArray(genArray);
Console.WriteLine();
int [,] reversedArray = reversedFistAndEndRows(genArray);
Print2dGenArray(reversedArray);



int[,] reversedFistAndEndRows (int [,] array)
{
    int [,] revArray = new int [array.GetLength(0), array.GetLength(1)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (i == 0) 
            revArray[i, j] = array[array.GetLength(0)-1, j];
            else
            revArray[i, j] = array[i, j];
            if (i == array.GetLength(0)-1)
            {
                revArray[i, j] = array[0, j];
            }
        }
    }
    return revArray;
}

// Генерация 2d массива с раномными строками/столбцами и значениями
int[,] GeneratedRandom2dArray()
{
    Random rnd = new Random();
    int rows = rnd.Next(3,7);
    int columns = rnd.Next(3,7);
    int[,] array = new int[rows, columns];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(-20,21);
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
           // Console.SetCursorPosition((0+6*j), 0);
            Console.Write($"[{array[i, j]}]" + "\t");
        }
        Console.WriteLine();
    }
}