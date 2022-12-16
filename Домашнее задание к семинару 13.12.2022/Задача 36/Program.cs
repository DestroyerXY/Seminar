// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

void InputArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
      array[i] = new Random().Next(-100, 101);
}

void ReleaseArray(int[]array)
{
    int SummEl = 0;
    for (int i = 1; i < array.Length; i = i + 2)
    {
        SummEl = SummEl + array[i];
    }
    Console.WriteLine(SummEl);
}

Console.Clear();
Console.Write("Напишите необходимое количество цифр в массиве:");
int n = Convert.ToInt32(Console.ReadLine());
int [] array = new int [n];
InputArray(array);
Console.WriteLine($"[{string.Join(", ", array)}]");
ReleaseArray(array);
