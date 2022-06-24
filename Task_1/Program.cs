// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее

Console.WriteLine("Введите число A ");
int numA = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число B ");
int numB = int.Parse(Console.ReadLine());

if ((numA > numB))
{
    Console.WriteLine($"Число {numA} является максимальным ");
}
else
{
    Console.WriteLine($"Число {numB} является максиамльным");
}
