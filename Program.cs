

// Задача 2: Напишите программу, которая на вход принимает два числа
//  и выдаёт, какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

// Console.Write("Введите число a : ");
// int numberA = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите число b: ");
// int numberB = Convert.ToInt32(Console.ReadLine());
// if (numberA > numberB)
// {
//     Console.WriteLine($"Число {numberA} является большим, а число {numberB} - меньшим");
// }
// else
// {
//     Console.WriteLine($"Число {numberB} является большим, а число {numberA} - меньшим");
// }


// Задача 6: Напишите программу, которая на вход принимает число 
// и выдаёт, является ли число чётным (делится ли оно на два 
// без остатка).

// 4 -> да
// -3 -> нет
// 7 -> нет

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number / 2)
{
    Console.WriteLine($"Число {number} делится без остатка");
}
else if (number % 2)
{
    Console.WriteLine($"Число {number} делится с остатком");
}