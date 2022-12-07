// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет


Console.Clear();

Console.WriteLine("Ведите цифру, означающую день недели: ");
int day = Convert.ToInt32(Console.ReadLine());
Console.Write($"день {day} - это " );

if (day >=0 && day <= 7) 
  {
if (day >= 1 && day < 6)
    Console.WriteLine("будний день");
else
    Console.WriteLine("выходной");
  }
else
    Console.WriteLine("не день недели");