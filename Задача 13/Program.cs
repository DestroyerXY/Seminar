
// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// НЕ ИСПОЛЬЗОВАТЬ НУМЕРАЦИЮ СТРОК
// 645 -> 5

// 78 -> третьей цифры нет

// 32679 -> 6
Console.Clear();

Console.Write("Введите число: ");
string? n = Console.ReadLine();

int x = Int32.Parse(n); 
if ( x > 99 )
    Console.WriteLine(Convert.ToInt32(n[2].ToString()));

else 
    Console.WriteLine("Третьей цифры нет");