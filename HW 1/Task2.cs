// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

System.Console.WriteLine("Введите три числа:");

int numberA = Convert.ToInt32(Console.ReadLine()); // int.Parse() || Convert.ToInt32
int numberB = Convert.ToInt32(Console.ReadLine()); // int.Parse() || Convert.ToInt32
int numberС = Convert.ToInt32(Console.ReadLine()); // int.Parse() || Convert.ToInt32
int max = 0;

if (numberA > numberB)
{
    max = numberA;
    if (max > numberС)
    {
        System.Console.WriteLine($"max = {max}");
    }
    else if (max < numberС)
    {
        max = numberС;
        System.Console.WriteLine($"max = {max}");
    }
    else
    {
        System.Console.WriteLine("Одного Максимального числа нет");
    }


}
else if (numberB > numberA)
{
    max = numberB;
    if (max > numberС)
    {
        System.Console.WriteLine($"max = {max}");
    }
    else if (max < numberС)
    {
        max = numberС;
        System.Console.WriteLine($"max = {max}");
    }
    else
    {
        System.Console.WriteLine("Одного Максимального числа нет");
    }

}

else
{
    if (numberС > numberA)
    {

        max = numberС;
        System.Console.WriteLine($"max = {max}");

    }
    else
    {
        System.Console.WriteLine("Одного Максимального числа нет");
    }

}

