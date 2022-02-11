// Даны два числа. Показать большее и меньшее число
int a = 6;
int b = 10;
int max = a;
int min = a;
if (a > max) max = a;
if (b > max) max = b;
if (a < min) max = a;
if (b < min) max = b;
Console.Write("max = ");
Console.WriteLine(max);
Console.Write("min = ");
Console.WriteLine(min);