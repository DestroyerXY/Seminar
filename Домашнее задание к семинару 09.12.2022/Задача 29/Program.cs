// Задача 29: Напишите программу, которая спрашивает у пользователя кол-во элементов и спршивает сами элементы. 
// После записи элементов в массив, необходимо его вывести на экран.
// 8
// 1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]

Console.Clear();
Console.WriteLine("Напишите количество элементов массива:");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int [n];
Console.WriteLine("Напишите элементы массива:");
int b = Convert.ToInt32(Console.ReadLine());
for (int b = 0; b < array.Length; b++)
    array[b] = new int().Next(0, n);
Console.WriteLine($"[{string.Join(" , ", array)}]");