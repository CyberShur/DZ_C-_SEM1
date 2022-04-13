//Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа. 456 -> 6 782 -> 2 918 -> 8

Console.Write("Введите трёхзначное число: ");
int Number = Convert.ToInt32(Console.ReadLine());

int Number3 = Number % 10;

Console.WriteLine(Number3);