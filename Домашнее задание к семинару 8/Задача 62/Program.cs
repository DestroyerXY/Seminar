// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

void PrintArray(int[,] spiral)
{
    for (int i = 0; i < spiral.GetLength(0); i++)
    {
        for (int j = 0; j < spiral.GetLength(1); j++)
        {
            Console.Write(spiral[i, j] + " \t");
        }
        Console.WriteLine();
    }
}


Console.Write("Введите размер массива: ");
int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
int[,] spiral = new int[size[0], size[1]];
int start = 1;
int i = 0;
int j = 0;

while (start <= size[0] * size[1])
{
    spiral[i, j] = start;
    if (i <= j + 1 && i + j < size[0] - 1)
        j++;
    else if (i < j && i + j >= size[0] - 1)
        i++;
    else if (i >= j && i + j > size[0] - 1)
        j--;
    else
        i--;
    start++;
}
PrintArray(spiral);  //Списал вслепую, не понял вообще. Нужно разобрать на примере.