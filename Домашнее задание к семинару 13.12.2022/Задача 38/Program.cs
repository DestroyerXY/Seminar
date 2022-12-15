// Задача 38: Задайте массив вещественных чисел.
//  Найдите разницу между максимальным и 
//  минимальным элементов массива.

// [3 7 22 2 78] -> 76

void InputArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
      array[i] = new Random().Next(-100, 101);
}

void ReleaseArray(int[]array)
{
    int Max = 0;
    for (int i = 0; i < array.Length; i++)
    {
       if (array[i] > Max)
         Max = array[i];
    }
    int Min = 0;
    for (int i = 0; i < array.Length; i++)
    {
       if (array[i] < Min)
         Min = array[i];
    }
Console.WriteLine(Max - Min);
}

Console.Clear();
Console.Write("Напишите необходимое количество цифр в массиве:");
int n = Convert.ToInt32(Console.ReadLine());
int [] array = new int [n];
InputArray(array);
Console.WriteLine($"[{string.Join(",", array)}]");
ReleaseArray(array);
