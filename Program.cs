// Задача 34: Задайте массив заполненный случайными положительными 
// трёхзначными числами. Напишите программу, которая покажет 
// количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2


// Console.Clear();
// int[] ar = new int[5];
// int q = 0;
// for (int i = 0; i < ar.Length; i++)
// {
//     ar[i] = new Random().Next(100, 1000);
//     Console.Write(ar[i]);
// }
// Console.WriteLine();
// for (int i = 0; i < ar.Length; i++)
// {
//     if (ar[i] % 2 == 0)
// {
//       q++;
// }
// }
// Console.WriteLine($"количество чётных чисел в массиве равно {q}");


// Задача 36: Задайте одномерный массив, заполненный случайными 
// числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0


// Console.Clear();
// int[] ar = new int[7];
// int sum = 0;
// for (int i = 0; i < ar.Length; i++)
// {
//     ar[i] = new Random().Next(0, 10);
//     Console.Write(ar[i]);
// }
// Console.WriteLine();
// for (int i = 0; i < ar.Length; i = i + 2)
// {
//     sum = sum + ar[i];
// }
// Console.WriteLine($"Сумма значений на нечетных позициях {sum}");



// Задача 38: Задайте массив вещественных чисел. Найдите разницу 
// между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76


// Console.Clear();
// double[] ar = new double[7];
// for (int i = 0; i < ar.Length; i++)
// {
//     ar[i] = Math.Round(new Random().Next(0, 10) + new Random().NextDouble(), 2);
//     Console.WriteLine(ar[i]);
// }
// Console.WriteLine();
// double min = ar[0];
// double max = ar[0];
// for (int i = 1; i < ar.Length; i++)
// {
//     if (ar[i] > ar[0])
//     max = ar[i];
//     if (ar[i] < ar[0])
//     min = ar[i];
// }
// double res = Math.Round(max - min, 2);
// Console.WriteLine($"Разница между максимальным {max} и минимальным {min} значением равна {res}");

