// Задача 21
// Напишите программу, которая принимает на вход координаты 
// двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

// Console.WriteLine("Введите X первой точки ");
// int X1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите Y первой точки ");
// int Y1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите Z первой точки ");
// int Z1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите X второй точки ");
// int X2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите Y второй точки ");
// int Y2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите Z ворой точки ");
// int Z2 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine(Math.Round(Math.Sqrt(Math.Pow((X2-X1),2) + Math.Pow((Y2-Y1),2) + Math.Pow((Z2-Z1),2)),2));


// Задача 23
// Напишите программу, которая принимает на вход число (N) 
// и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

// Console.WriteLine("Введите число N ");
// int n = Convert.ToInt32 (Console.ReadLine());
// for (int i = 1; i <= n; i++)
// {
//     Console.WriteLine(Math.Pow(i,3));
// }


// Задача 19
// Напишите программу, которая принимает на вход пятизначное число 
// и проверяет, является ли оно палиндромом.

// 14212 -> нет
// 12821 -> да
// 23432 -> да

// Console.Write("Введите пятизначное число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// if (number >= 100000 || number <= 9999)
// {
//     Console.WriteLine($"Неправильно выполнено условие");
// }

// int number2 = number % 10;
// int number3 = number % 100;
// int number4 = number % 1000;
// int number5 = number % 10000;

// int res = number/10000;
// int res5 = (number5 - number4)/1000;
// int res4 = (number4 - number3)/100;
// int res3 = (number3 - number2)/10;
// int res2 = (number2);

// if (res == res2 && res5 == res3)
// {
//     Console.WriteLine($"{number} является палиндромом");
// }
// else
// {
//     Console.WriteLine($"{number} не палиндром");
// }