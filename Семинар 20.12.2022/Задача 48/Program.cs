// Задача 48. Задайте двумерный массив размера 
// m на n, каждый элемент в массиве находится 
// по формуле: Aₘₙ = m+n. 
// Выведите полученный массив на экран.

void InputMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            //matrix[i, j] = new Random().Next(-10, 11); // [-10, 10]
            matrix[i, j] = i + j;
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