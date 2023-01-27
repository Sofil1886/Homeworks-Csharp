// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

System.Console.WriteLine("Введите число:");

int N = Convert.ToInt32(Console.ReadLine()); // int.Parse() || Convert.ToInt32
if (N > 1)
{
    for (int i = 2; i <= N; i += 2)
    {
        System.Console.Write(i + " ");
    }

}
else
{
    System.Console.WriteLine("Четных положительных чисел нет");
}

