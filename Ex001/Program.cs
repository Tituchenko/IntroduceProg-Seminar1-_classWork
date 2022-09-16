// Написать программу которая на вход принимает число и выдает ее квадрат
Console.WriteLine ("Введи число ");
int number=int.Parse(Console.ReadLine());

// Квадрат математически
int sqr=number*number;

Console.WriteLine ($"Квадрат {number} равен {sqr}");

// Метод из библиотеки math

int sqr1=Convert.ToInt32(Math.Pow(number,2));
Console.WriteLine ($"Метод из библитеки:Квадрат {number} равен {sqr}");