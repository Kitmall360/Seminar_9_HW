﻿// Задача 64: Задайте значение N. 
// Напишите программу, которая выведет все натуральные числа 
// в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.Write("Введите натуральное число: ");
int number = Convert.ToInt32(Console.ReadLine());
if(number < 1)
{
    Console.WriteLine("Введено некорректное число!");
    return;
}

Console.Write($"N = {number} -> ");
NatureNumber(number);

void NatureNumber(int num)
{
    if (num == 0) return;
    Console.Write($"{num} ");
    NatureNumber(num - 1);
}