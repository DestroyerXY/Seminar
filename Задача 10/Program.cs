// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.Clear();

Console.Write("Введите трехзначное число: ");
string? n = Console.ReadLine();

int x = Int32.Parse(n); 
if (x > 99 && x < 1000)
    Console.WriteLine(Convert.ToInt32(n[1].ToString()));

else 
    Console.WriteLine("Число неверное");