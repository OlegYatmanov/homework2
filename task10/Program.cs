using System;
using static System.Console;
Clear();

Write("Введи трёхзначное число: ");
int number = int.Parse(ReadLine());
string stringNumber = Convert.ToString(number);
WriteLine("Вторая цифра -> "+stringNumber[1]);