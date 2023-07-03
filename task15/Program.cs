using System;
using static System.Console;
Clear();

Write("Введи цифру, обозначающую день недели: ");
int dayNumber = int.Parse(ReadLine());

void CheckingTheDayOfTheWeek (int dayNumber) {
  if (dayNumber == 6 || dayNumber == 7)
  {
  WriteLine($"{dayNumber} -> да");
  }
  else WriteLine($"{dayNumber} -> нет");
}

CheckingTheDayOfTheWeek(dayNumber);