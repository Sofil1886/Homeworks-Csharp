﻿// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

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



// // Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// System.Console.WriteLine("Введите три числа:");

// int numberA = Convert.ToInt32(Console.ReadLine()); // int.Parse() || Convert.ToInt32
// int numberB = Convert.ToInt32(Console.ReadLine()); // int.Parse() || Convert.ToInt32
// int numberС = Convert.ToInt32(Console.ReadLine()); // int.Parse() || Convert.ToInt32
// int max = 0;
// int min = 0;

// if (numberA > numberB)
// {
//     max = numberA;
//     if (max > numberС)
//     {
//         System.Console.WriteLine($"max = {max}");
//     }
//     else if (max < numberС)
//     {
//         max = numberС;
//         System.Console.WriteLine($"max = {max}");
//     }

//     else
//     {
//         System.Console.WriteLine("Одного Максимального числа нет");
//     }

// }
// else if (numberB > numberA)
// {
//     max = numberB;
//     if (max > numberС)
//     {
//         System.Console.WriteLine($"max = {max}");
//     }
//     else if (max < numberС)
//     {
//         max = numberС;
//         System.Console.WriteLine($"max = {max}");
//     }

//     else
//     {
//         System.Console.WriteLine("Одного Максимального числа нет");
//     }
// }
// else
// {
//         max = numberB;
//     if (max > numberС)
//     {
//         System.Console.WriteLine($"max = {max}");
//     }
//     else if (max < numberС)
//     {
//         max = numberС;
//         System.Console.WriteLine($"max = {max}");
//     }

//     else
//     {
//         System.Console.WriteLine("Одного Максимального числа нет");
//     }
// }


// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

