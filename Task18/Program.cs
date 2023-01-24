/*  Напишите программу, которая по заданному номеру четверти показывает диапазон возможных координат
точек в этой четверти (x и y)   */

int GetQuarter(string message)
{
int resultQuarter = 0;

while(true)
{
Console.WriteLine(message);

if(int.TryParse(Console.ReadLine(), out resultQuarter) && 0 < resultQuarter && resultQuarter < 5)
{
break;
}
else
{
Console.WriteLine("Ввели не число или не корректное число. Повторите ввод!\n");
}
}
return resultQuarter;
}

int quarter = GetQuarter("Введите номер четверти");

if(quarter == 1) Console.WriteLine($"В {quarter} четверти возможные координаты точек: x > 0 ; y > 0");
if(quarter == 2) Console.WriteLine($"Во {quarter} четверти возможные координаты точек: x < 0 ; y > 0");
if(quarter == 3) Console.WriteLine($"В {quarter} четверти возможные координаты точек: x < 0 ; y < 0");
if(quarter == 4) Console.WriteLine($"В {quarter} четверти возможные координаты точек: x > 0 ; y < 0");