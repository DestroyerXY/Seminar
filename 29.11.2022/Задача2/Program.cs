Console.Clear();

int i = 1;

Console.Write("Write number: ");

int n = Convert.ToInt32(Console.ReadLine());

while (i <= n)
{
   if (i%2 == 0)
    {
        Console.Write($"{i} ");
        i = i + 2;
    }
   else
    {
        i = i + 1;
    }
}