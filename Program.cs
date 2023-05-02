// See https://aka.ms/new-console-template for more information


// int numberA = 123;
// string userName = "Bob"; 

// Console.WriteLine("Hello, World!");
// Console.Write(numberA);
// Console.Write(userName);
// Console.WriteLine();
// Console.Write("Введите имя пользователя: ");
// string name = Console.ReadLine();
// Console.WriteLine($"Имя пользователя {numberA + 100} компьютера {name}");

// Console.Write("Введите возраст пользователя: ");
// int age = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine($"Имя пользователя {numberA + 100} компьютера {name}. А его возраст {age + 2} лет");

// string num1 = Console.ReadLine();
// string num2 = Console.ReadLine();
// Console.Write($"  {num1 + num2}");

// Напишите программу, которая на вход прининает число и выдает его квадрат

// Console.Write("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// int result = number * number;
// Console.WriteLine($"Квадрат {number} = {result}");

// Console.Write("Введите число 1 : ");
// int number1 = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите число 2: ");
// int number2 = Convert.ToInt32(Console.ReadLine());
// if (number1 > number2)
// {
//     Console.WriteLine($"Квадрат {number1} = {number1 * number1}");
// }
// else
// {
//     Console.WriteLine($"Квадрат {number2} = {number2 * number2}");
// }

// index = index + 1;
// index += 1;
// index++;

// написать программу, которая на вход принимает два числа и проверяет, 
// является ли первое число квадратом второго

// Console.Write("Введите число 1 : ");
// int number1 = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите число 2: ");
// int number2 = Convert.ToInt32(Console.ReadLine());
// if (number1 == number2 * number2)
// {
//     Console.WriteLine($"Число {number1} является квадратом числа {number2}");
// }
// else
// {
//     Console.WriteLine($"Число {number1} не является квадратом числа {number2}");
// }

// Напишите программу, которая будет выдавать название 
// дня недели по заданному номеру

Console.Write("Введите номер дня недели: ");
int weeknum = Convert.ToInt32(Console.ReadLine());
if (weeknum == 3)
{
    Console.WriteLine($"Среда");
}
else if (weeknum == 1)
{
    Console.WriteLine($"Понедельник");
}
else
{
    Console.WriteLine($"Нет данных");
}