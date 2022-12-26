// Задача 50. Напишите программу, которая на вход принимает позиции
//  элемента в двумерном массиве, и возвращает значение этого элемента 
//  или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 1 7 -> такой позиции в массиве нет (пользователь вводит нумерацию с 1)

void InputMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(-10, 11); // [-10, 10]
            Console.Write($"{matrix[i, j]} \t");
        }
        Console.WriteLine();
    }
}


Console.Clear();
Console.Write("Введите размеры матрицы: ");
int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
int[,] matrix = new int[size[0], size[1]];
InputMatrix(matrix);
Console.Write("Введите позицию массива: ");
int[] mas = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
if (matrix.GetLength(1) < mas[1] || matrix.GetLength(0) < mas[0])
    Console.Write("Такой позиции в массиве нет");
for (int i = 0; i < matrix.GetLength(0); i++)
    {
        if (i == mas[0]-1)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (j == mas[1]-1)
                    Console.WriteLine($"Искомый элемент = {matrix[i,j]}");
                
            }
        }
    }

