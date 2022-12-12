// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// Нельзя использовать функцию Math.Pow
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.Clear();
Console.WriteLine ("Введите число А:");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Введите число В:");
int B = Convert.ToInt32(Console.ReadLine()), result = 1, count = 0;
for ( count = 1 ; count <= B ; count++ )
   result = result * A;
Console.WriteLine(result);
