// Напишите программу,
// которая принимает на вход координаты
// двух точек и находит расстояние между
// ними в 2D пространстве.
// A (3,6); B (2,1) -> 5,09
// // A (7,-5); B (1,-1) -> 7,21

Console.Clear();
Console.Write("Введите координату x1 : ");
double x1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату y1 : ");
double y1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату x2 : ");
double x2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату y2: ");
double y2 = Convert.ToDouble(Console.ReadLine());

double result1 = Math.Pow((x1-x2),2);
double result2 = Math.Pow((y1-y2),2);
double result = Math.Sqrt(result1+result2);

Console.WriteLine(result);