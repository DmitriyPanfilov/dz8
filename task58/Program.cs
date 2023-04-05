// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

void InputMatrix(int[,] matrix)
{
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = new Random().Next(1,10); // 1 - 9
        }
    }
}

void PrintMatrix(int[,] matrix)

{
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i,j]}\t");
        }
        Console.WriteLine();
    }
}

void ProductMatrices(int[,] matrix1, int[,] matrix2, int[,] resaltmatrix)
{
    if(matrix1.GetLength(1) == matrix2.GetLength(0))
    {
        for (int i = 0; i < matrix1.GetLength(0); i++)
        {
            for (int j = 0; j < matrix2.GetLength(1); j++)
            {
                resaltmatrix[i,j] = 0;
                for(int k = 0; k < matrix1.GetLength(1); k++)
                {
                    resaltmatrix[i, j] += matrix1[i, k] * matrix2[k, j];


                }

            }
        }
    
    }
    else
    {
        System.Console.WriteLine("Произведение матриц невозсомжно, не верно введена матрица");
    }

}


Console.Clear();
Console.Write("Введите размер матрицы: ");
int[] size1 = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
int[,] matrix1 = new int[size1[0], size1[1]];
Console.Write("Введите размер матрицы: ");
int[] size2 = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
int[,] matrix2 = new int[size2[0], size2[1]];
int[,] resaltmatrix = new int[size1[1],size2[0]];
InputMatrix(matrix1);
InputMatrix(matrix2);
ProductMatrices(matrix1, matrix2, resaltmatrix);
PrintMatrix(matrix1);
Console.WriteLine();
PrintMatrix(matrix2);
Console.WriteLine();
PrintMatrix(resaltmatrix);