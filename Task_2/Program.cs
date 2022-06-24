// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел
Console.WriteLine("Введите число A");
int numA = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число B"); 
int numB = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число C");
int numC = int.Parse(Console.ReadLine());

if (numA > numB && numA > numC)
{
    Console.WriteLine($"Число {numA} максимальное");
}
else if (numB > numA && numB > numC)
{
    Console.WriteLine($"Число {numB} максимальное");
}
else
{
    Console.WriteLine($"Число {numC} максимальное");
} 
    