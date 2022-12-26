// Задача 57. Составить частотный словарь элементов двумерного массива. 
// Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.

bool checkValue(int[] array, int numbers)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == numbers)
            return false;
    }
    return true;
}


int InputMatrix(int[,] matrix, int[] array)
{
    int k = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 11); // [1, 10]
            Console.Write($"{matrix[i, j]} \t");
            if (checkValue(array, matrix[i, j]))
            {
                array[k] = matrix[i, j];
                k++;
            }
        }
        Console.WriteLine();
    }
    return k;
}


void SwapFirstLastString(int[,] matrix, int[] array, int countNumbers)
{
    for (int k = 0; k < countNumbers; k++)
    {
        int count = 1;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (array[k] == matrix[i, j])
                    count++;
            }
        }
        Console.WriteLine($"Элемент {array[k]} встречается {count}  раз");   
    }
}

Console.Clear();
Console.Write("Введите размер матрицы: ");
int[] coord = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
int[,] matrix = new int[coord[0], coord[1]];
int[] array = new int[coord[0] * coord[1]];
Console.WriteLine("Начальный массив");
int count = InputMatrix(matrix, array);
Console.WriteLine("Конечный массив");
SwapFirstLastString(matrix, array, count);