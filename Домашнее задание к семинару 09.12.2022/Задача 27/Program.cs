// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12

Console.Clear();
Console.Write("Напишите число: ");
int n = Convert.ToInt32(Console.ReadLine()), result = 0;
while (n > 0)
{
   int a = n%10;
   result = result + a;
   n /= 10;
}
Console.WriteLine($"Сумма цифр числа равна {result}");