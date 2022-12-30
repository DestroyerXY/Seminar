// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int Akk(int a, int b)
{
    if (a == 0)
        return b + 1;
    else if (b == 0)
        return Akk(a - 1, 1);
    return Akk(a - 1, Akk(a, b - 1));
}


Console.Clear();
Console.Write("Введите 1-ое число: ");
int m = Convert.ToInt32(Console.ReadLine());
while (m < 0)
{
    Console.Write("Введите 1-ое число: ");
    m = Convert.ToInt32(Console.ReadLine());
}
Console.Write("Введите 2-ое число: ");
int n = Convert.ToInt32(Console.ReadLine());
while (n < 0)
{
    Console.Write("Введите 2-ое число: ");
    n = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine(Akk(m, n));