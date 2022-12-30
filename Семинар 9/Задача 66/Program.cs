// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int sum(int a, int b)
{
    if (a == b)
        return a;
    return sum(a + 1, b) + a;
}


Console.Clear();
Console.Write("Введите 1-ое число: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите 2-ое число: ");
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(sum(M, N));