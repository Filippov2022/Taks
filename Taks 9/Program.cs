// Показать последнюю цифру трёхзначного числа
Console.WriteLine("Введите число: ");
int a = int.Parse(Console.ReadLine());
int c = (a % 10);

Console.WriteLine(c);