// Задача 27: Напишите программу, которая принимает на вход число 
// и выдаёт сумму цифр в числе.

// 452 -> 11
// 82 -> 10
// 9012 -> 12

// Console.WriteLine("Bведите число: ");
// int n = Convert.ToInt32 (Console.ReadLine());
// int sum = 0;
// while (n > 0)
// {
// int num = n % 10;
// sum = sum + num;
// n = n / 10;
// }
// Console.WriteLine($"Сумма цифр равна {sum}");


// Задача 29: Напишите программу, которая задаёт массив 
// из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]


// int[] ar = new int[8] {1, 2, 5, 7, 19, 6, 1, 33};
// for (int i = 0; i < ar.Length; i++)
// {
//     Console.Write(ar[i]);
// }


// Задача 25: Напишите цикл, который принимает на вход 
// два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

// Console.WriteLine("Введите число А: ");
// int na = Convert.ToInt32 (Console.ReadLine());
// Console.WriteLine("Введите число В: ");
// int nb = Convert.ToInt32 (Console.ReadLine());
// if (nb >= 0)
// {
// Console.Write($"Число {na} в степени {nb} равно {Math.Pow(na, nb)}");
// }
// else
// {
//     Console.Write($"Показатель не должен быть меньше нуля");
// }