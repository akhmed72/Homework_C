﻿// Напишите программу, которая на вход принимает число и выдаёт,
// является ли число чётным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет

Console.WriteLine("Введите число > ");
string inputValue = Console.ReadLine();
int A = Convert.ToInt32(inputValue); 

if(A%2==0)
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}