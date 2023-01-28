﻿/*Задача 2: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

452 -> 11

82 -> 10

9012 -> 12

*/

int GetValue(string msg)
{
    System.Console.WriteLine(msg);
    string v = Console.ReadLine();
    return Convert.ToInt32(v);
}

int Summ(int number)

{
    int sum = 0;
    while (number != 0)
    {
        int digit = number % 10;
        sum += digit;
        number /= 10;
    }
return sum;
}

int number = GetValue("Введите число: ");
int result = Summ(number);
Console.WriteLine("Сумма чисел в нем : " + result);

