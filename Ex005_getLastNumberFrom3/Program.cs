// На входе получает трехзначное число, на выходе последнюю цифру
Console.Write ("Введите трехзначное число: ");
int number=int.Parse(Console.ReadLine());
int thirdnumber=number%10; //третья цифра

Console.WriteLine ($"Послденяя цифра числа {number} это {thirdnumber}");