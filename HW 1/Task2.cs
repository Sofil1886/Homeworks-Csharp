// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

System.Console.WriteLine("Введите два числа:");

int numberA = Convert.ToInt32(Console.ReadLine()); // int.Parse() || Convert.ToInt32
int numberB = Convert.ToInt32(Console.ReadLine()); // int.Parse() || Convert.ToInt32
int max = 0;
int min = 0;

if (numberA > numberB)
{
    max = numberA;
    min = numberB;
    System.Console.WriteLine($"max = {max}");
    System.Console.WriteLine($"min = {min}");
}
else if (numberB > numberA)
{
    max = numberB;
    min = numberA;
    System.Console.WriteLine($"max = {max}");
    System.Console.WriteLine($"min = {min}");
}
else
{
    System.Console.WriteLine("Числа равны");
}
