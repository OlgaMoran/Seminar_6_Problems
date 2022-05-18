// ДЗ Задача 2: Найти произведение двух матриц

void FillArray(double[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(1, 6);
        }
    }
}
void PrintArray(double[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}

// int MatrMult(int[,] matrix1, int[,] matrix2)
// {
//     if (matrix1.GetLength(1) != matrix2.GetLength(0)) Console.WriteLine("Multiplication is impossible. ");
//     int[,] result = new int[matrix1.GetLength(0), matrix2.GetLength(1)];
//     for (int i = 0; i < matrix1.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix2.GetLength(1); j++)
//         {
//             for (int k = 0; k < matrix2.GetLength(0); k++)
//             {
//                 result[i, j] = matrix1[i, k] * matrix2[k, j];
//             }
//         }
//         return result;
//     }
// }

double MatrMult(double[,] a, double[,] b)
{
    //if (matrix1.GetLength(1) != matrix2.GetLength(0)) Console.WriteLine("Multiplication is impossible. ");
    double[,] result = new double[2, 2];
    for (int i = 0; i < 2; i++)
    {
        for (int j = 0; j < 2; j++)
        {
            for (int k = 0; k < 2; k++)
            {
                result[i, j] = a[i, k] * b[k, j];
            }
        }
    }
    return result[2, 2];
}

double[,] matr1 = new double[2, 2];
FillArray(matr1);
Console.WriteLine();
PrintArray(matr1);
Console.WriteLine();

double[,] matr2 = new double[2, 2];
FillArray(matr2);
Console.WriteLine();
PrintArray(matr2);
Console.WriteLine();

MatrMult(matr1, matr2);
