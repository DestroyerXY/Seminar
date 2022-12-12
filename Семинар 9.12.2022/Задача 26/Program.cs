// Задача 26: Напишите программу, которая
// принимает на вход число и выдаёт количество
// цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

Console.Clear();
Console.Write("Введите число:");
int n = Convert.ToInt32(Console.ReadLine()), count = 0;
while (n > 0)
{
    count++;
    n /= 10;
}
Console.WriteLine(count);