// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

System.Console.WriteLine("Введите число:");

int numberA = Convert.ToInt32(Console.ReadLine()); // int.Parse() || Convert.ToInt32

if (numberA % 2 == 0)
{
    System.Console.WriteLine("Да");
}
else
{
    System.Console.WriteLine("Нет");
}

// 4 -> да
// -3 -> нет
// 7 -> нет
