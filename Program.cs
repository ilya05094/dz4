// Задача 25
// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.



// int numberA = ReadInt("Введите число A: ");
// int numberB = ReadInt("Введите число B: ");
// ToDegree(numberA, numberB);


// // Функция возведения в степень
// void ToDegree(int a, int b)
// {
//     int result = 1;
//     for (int i = 1; i <= b; i++)
//     {
//         result = result * a;
//     }
//     Console.WriteLine(result);
// }

// // Функция ввода
// int ReadInt(string message)
// {
//     Console.WriteLine(message);
//     return Convert.ToInt32(Console.ReadLine());
// }


// Задача 27
// Напишите программу, которая принимает на вход число и выдает сумму цифр в числе.

// Console.Clear();
// int сумма = 0;
// System.Console.Write("введите число:");
// string num = Console.ReadLine();
// for (int i = 0; i < num.Length; i++)
// {
//     string line;
//     line = Convert.ToString(num[i]);
//     int number = Convert.ToInt32(line);
//     сумма += number;
// }
// System.Console.WriteLine("сумма равна: "  + сумма);

// Задача 29
// Напишите программу, которая задаёт массив из n элементов и выводит их на экран.

// int lenArray = ReadInt("Введите длину массива: ");

// int[] randomArray = new int[lenArray];
// for (int i = 0; i < randomArray.Length; i++)
// {
//     randomArray[i] = new Random().Next(1,9);
//     Console.Write(randomArray[i] + " ");
// }


// // Функция ввода
// int ReadInt(string message)
// {
//     Console.Write(message);
//     return Convert.ToInt32(Console.ReadLine());
// }

