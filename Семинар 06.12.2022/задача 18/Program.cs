// Напишите программу, которая по
// заданному номеру четверти, показывает
// диапазон возможных координат точек в этой
// четверти (x и y).

Console.Clear();

Console.Write("Введите квадрант: ");
int n = Convert.ToInt32(Console.ReadLine());

while (n < 1 || n > 4)
{
    Console.WriteLine("Вы ошиблись! \n Введите цифру от 1 до 4: ");
    n = Convert.ToInt32(Console.ReadLine());
}

if ( n == 1 )
   Console.WriteLine("x > 0 , y > 0");
else if ( n == 2 )
    Console.WriteLine("x < 0 , y > 0 ");
else if ( n == 3 )
    Console.WriteLine( "x < 0 , y < 0 " );
else 
    Console.WriteLine("x > 0 , y < 0" );