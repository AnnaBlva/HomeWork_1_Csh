// Задача 10: Напишите программу, которая принимает на вход 
// трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

// Console.Write("Введите трехзначное число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// int n2 = number % 100 / 10;
// Console.WriteLine($"{number} ");
// Console.WriteLine($"{n2} ");


// Задача 13: Напишите программу, которая выводит третью цифру 
// заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6


// Console.Write("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// int num = Math.Abs(num);
// int lenghtNb = 0;
// int result = nb1;
// while (result > 0)
// {
//     result = result / 10;
//     lenghtNb++;
// }
// int [] arr = new int [lenghtNb];
// for (int i = 0; i < lenghtNb; i++)
// { 
//     arr [i] = nb1 % 10;
//     nb1 /= 10;
// }


// Задача 15: Напишите программу, которая принимает на вход цифру,
// обозначающую день недели, и проверяет, 
// является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет


// Console.Write("Введите номер дня недели: ");
// int daynumber = Convert.ToInt32(Console.ReadLine());
// if (daynumber < 1 || daynumber > 7)
// {
//     Console.WriteLine($"Дня недели под таким номером не существует");
// }
// else if (daynumber >= 6 && daynumber <=7)
// {
//     Console.WriteLine($"День недели под номером {daynumber} является выходным днем");
// }
// else 
// {
//     Console.WriteLine($"День недели под номером {daynumber} является будним днем");
// }
