// ДЗ ЗАДАЧА 1. Составить частотный словарь элементов двумерного массива

void FillArray(int[,] matrix)
{
    int x = matrix.GetLength(0);
    int y = matrix.GetLength(1);
    for (int i = 0; i < x; i++)
    {
        for (int j = 0; j < y; j++)
        {
            matrix[i, j] = new Random().Next(0, 10);
        }
    }
}

void PrintArray(int[,] matrix)
{
    int x = matrix.GetLength(0);
    int y = matrix.GetLength(1);
    for (int i = 0; i < x; i++)
    {
        for (int j = 0; j < y; j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
}

void ElementFrequencyForDigitsOnly(int[,] array)
{
    for (int comp = 0; comp <= 9; comp++)
    {
        int count = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                if (array[i, j] == comp) count++;
            }
        }
        if (count != 0)
        {
            if (count == 1) System.Console.WriteLine($"{comp} occurs 1 time");
            else System.Console.WriteLine($"{comp} occurs {count} times");
        }
    }
}

int[,] matr = new int[3, 3];
FillArray(matr);
PrintArray(matr);
Console.WriteLine();
ElementFrequencyForDigitsOnly(matr);
