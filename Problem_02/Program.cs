// ДЗ Задача 2: Найти произведение двух матриц
void FillArray(int[,] matrix)
{
    int x = matrix.GetLength(0);
    int y = matrix.GetLength(1);
    for (int i = 0; i < x; i++)
    {
        for (int j = 0; j < y; j++) matrix[i, j] = new Random().Next(1, 6);
    }
}

void PrintArray(int[,] matrix)
{
    int x = matrix.GetLength(0);
    int y = matrix.GetLength(1);
    for (int i = 0; i < x; i++)
    {
        for (int j = 0; j < y; j++) System.Console.Write($"{matrix[i, j]} ");
        System.Console.WriteLine();
    }
}

int[,] MatrixMultiplication(int[,] matr1, int[,] matr2)
{
    int x = matr1.GetLength(0);
    int y = matr2.GetLength(1);
    int z = matr1.GetLength(1);
    int[,] matr3 = new int[x, y];
    for (int i = 0; i < x; i++)
    {
        for (int j = 0; j < y; j++)
        {
            for (int k = 0; k < z; k++) matr3[i, j] += matr1[i, k] * matr2[k, j];
        }
    }
    return matr3;
}

int[,] A = new int[3, 2];
int[,] B = new int[2, 2];
int[,] C = new int[3, 2];

FillArray(A);
PrintArray(A);
Console.WriteLine();
FillArray(B);
PrintArray(B);
Console.WriteLine();
PrintArray(MatrixMultiplication(A, B));