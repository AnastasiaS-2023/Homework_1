// Задача 3. Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет

Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());

int div = a % 2;

if (div == 0)
    Console.WriteLine("yes");
else
    Console.WriteLine("no");