// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

void InputMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            matrix[i, j] = new Random().Next(0, 11); // [-10, 10]
    }
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            Console.Write($"{matrix[i, j]} \t");
        Console.WriteLine();
    }
}

int[,] ProductMatrix(int[,]matrix, int[,]matrix2, int[,]newMatrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            {
                newMatrix[i,j] = matrix[i,j]*matrix2[i,j];
            }
    }
    return newMatrix;
}


Console.Clear();
Console.WriteLine("Введите размер двухмерного массива: ");
int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
int[,] matrix = new int[size[0], size[1]];
int[,] matrix2= new int[size[0], size[1]];
Console.WriteLine("Первый массив:");
InputMatrix(matrix);
PrintMatrix(matrix);
Console.WriteLine();
Console.WriteLine("Второй массив:");
InputMatrix(matrix2);
PrintMatrix(matrix2);
Console.WriteLine();
int[,] newMatrix = new int [size[0], size[1]];
Console.WriteLine("Произведение элементов двух массивов:");
PrintMatrix(ProductMatrix(matrix, matrix2, newMatrix));