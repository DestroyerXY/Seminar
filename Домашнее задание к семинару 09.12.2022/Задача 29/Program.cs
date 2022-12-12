// Задача 29: Напишите программу, которая спрашивает у пользователя кол-во элементов и спршивает сами элементы. 
// После записи элементов в массив, необходимо его вывести на экран.
// 8
// 1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]

Console.Clear();
Console.WriteLine("Введите число элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int [] array = new int [n];
for (int i = 0; i < n; i ++)
    {
        Console.WriteLine("Введите число: ");
        array[i] = Convert.ToInt32(Console.ReadLine());

    }
    Console.WriteLine();  
Console.WriteLine($"[{string.Join(", ", array)}]");