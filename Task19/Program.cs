/*  Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.

A (3,6); B (2,1) -> 5,09
A (7,-5); B (1,-1) -> 7,21   */

int GetNumber(string message)
{
int resultNumber = 0;

while(true)
{
Console.WriteLine(message);

if(int.TryParse(Console.ReadLine(), out resultNumber))
{
break;
}
else
{
Console.WriteLine("Ввели не число или не корректное число. Повторите ввод!\n");
}
}
return resultNumber;
}

int pointAx = GetNumber("Введите координату X точки А: ");
int pointAy = GetNumber("Введите координату Y точки А: ");
int pointBx = GetNumber("Введите координату X точки B: ");
int pointBy = GetNumber("Введите координату X точки B: ");

double DistanceBetweenPoints = Math.Sqrt(Math.Pow((pointBx - pointAx), 2) + Math.Pow((pointBy - pointAy), 2));
DistanceBetweenPoints = Math.Round(DistanceBetweenPoints, 2);

Console.WriteLine($"Расстояние между точками А ({pointAx}, {pointAy}) и В ({pointBx}, {pointBy}) равно {DistanceBetweenPoints})");
