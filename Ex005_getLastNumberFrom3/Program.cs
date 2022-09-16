// На входе получает трехзначное число, на выходе последнюю цифру
Console.Write ("Введите трехзначное число: ");
int number=int.Parse(Console.ReadLine());
int firstNumber=number/100; //первая цифра
int secondNumber=(number-firstNumber*100)/10; // вторая цифра
int thirdnumber=number-firstNumber*100-secondNumber*10; //третья цифра
Console.WriteLine ($"Послденяя цифра числа {number} это {thirdnumber}");