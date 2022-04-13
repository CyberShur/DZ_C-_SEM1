// Задача 1: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.Write("Введите число A: ");
int NumberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B: ");
int NumberB = Convert.ToInt32(Console.ReadLine());

int max = 0;
int min = 0;

if (NumberA < NumberB)
{
    max = NumberB;
    min = NumberA;
}
else
{
    max = NumberA;
    min = NumberB;
}

Console.Write("Минимальное число: ");
Console.WriteLine(min);

Console.Write("Максимальное число: ");
Console.Write(max);