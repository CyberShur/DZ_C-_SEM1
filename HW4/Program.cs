// Задача 3: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

Console.Write("Введите число: ");
int Number = Convert.ToInt32(Console.ReadLine());

if (Number %2 == 0)
{
    Console.Write("Введённое число " + Number + " - чётное");
}
else
{
    Console.Write("Введённое число " + Number + " - нечётное");
}
