// Задача 2: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.Write("Введите число A: ");
int NumberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B: ");
int NumberB = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число C: ");
int NumberC = Convert.ToInt32(Console.ReadLine());

int max = NumberA;

if (NumberA > max) max = NumberA;
if (NumberB > max) max = NumberB;
if (NumberC > max) max = NumberC;

Console.Write("Максимальное число = ");
Console.WriteLine(max);