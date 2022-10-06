/*Напишите программу, которая принимает на вход координаты двух точек 
и находит расстояние между ними в 3D пространстве.*/

Console.Write("Введите координаты по X точки A: " );
int XpointA= Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координаты по Y точки A: " );
int YpointA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координаты по Z точки A: " );
int ZpointA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координаты по X точки B: " );
int XpointB = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координаты по Y точки B: " );
int YpointB = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координаты по Z точки B: " );
int ZpointB = Convert.ToInt32(Console.ReadLine());

double result = Math.Sqrt((Math.Pow(XpointA - XpointB,2)) + (Math.Pow(YpointA- YpointB,2)) + (Math.Pow(ZpointA - ZpointB,2)));
Console.WriteLine($"Расстояние между точками: {Math.Round(result,2)}");
