﻿// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

using static System.Console;
Clear();
WriteLine("Введите число: ");
int number = Convert.ToInt32(ReadLine());
WriteLine("Таблица кубов чисел от 1 до введённого числа: ");
 for (int i = 1; i <= number; i++)
 {
     Write($"{Math.Pow(i, 3)} ");
 }
 
 