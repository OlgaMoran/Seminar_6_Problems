// // ДЗ ЗАДАЧА 3. Показать треугольник Паскаля 

int[,] matrix = new int[10, 10];
matrix[0, 0] = 1;

for (int i = 1; i < 10; i++)
{
    for (int j = 0; j <= i; j++)
    {
        if (j == 0 | j == i) matrix[i, j] = 1;
        else matrix[i, j] = matrix[i - 1, j - 1] + matrix[i - 1, j];
    }
}

for (int i = 0; i < 10; i++)
{
    for (int j = 0; j < 10; j++)
    {
        if (matrix[i, j] != 0) System.Console.Write($"{matrix[i, j]} ");
        else System.Console.Write(" ");
    }
    System.Console.WriteLine();
}
