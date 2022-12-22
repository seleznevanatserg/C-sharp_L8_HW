/* Задача 57: Составить частотный словарь элементов двумерного массива. 
Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.
Набор данных
Частотный массив
{ 1, 9, 9, 0, 2, 8, 0, 9 }
0 встречается 2 раза 1 встречается 1 раз 2 встречается 1 раз 8 встречается 1 раз 9 встречается 3 раза
1, 2, 3 4, 6, 1 2, 1, 6
1 встречается 3 раза 2 встречается 2 раз 3 встречается 1 раз 4 встречается 1 раз 6 встречается 2 раза */




(int, int)[] CounterNumbers(int[,] array)
{
    (int, int)[] arrayCount = new int[array.GetLength(0) * array.GetLength(1)];

    int index = 0;
    while (index < arrayCount.Length)
    {
        (int, int) counter = (0,0);
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                if (counter.Item1 == array)
            }
        }
    }


    return arrayCount;
}

// Генерация массива с раномными строками/столбцами и значениями
int[,] GeneratedRandom2dArray()
{
    Random rnd = new Random();
    int rows = rnd.Next(3, 7);
    int columns = rnd.Next(3, 7);
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
            // Console.SetCursorPosition((0+6*j), 0);
            Console.Write($"[{array[i, j]}]" + "\t");
        }
        Console.WriteLine();
    }
}