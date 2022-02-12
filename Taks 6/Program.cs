// Выяснить является ли число чётным
int a;
Console.Write("Введите число: ");
a = Console.Read();
if (a % 2 == 1)
{
    Console.WriteLine("Число четное");
}
else
{
    Console.WriteLine("Число нечетное");
}
Console.ReadKey();