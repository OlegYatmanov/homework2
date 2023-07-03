using System;
using static System.Console;
Clear();

Write("Введи число: ");
int number = int.Parse(ReadLine());
string numberText = Convert.ToString(number);
if (numberText.Length > 2)
{
  WriteLine("третья цифра -> " + numberText[2]);
}
else {
  WriteLine("-> третьей цифры нет");
}