// Ввести два числа, проверить является ли второе квадратом первого
Console.Write ("Введите первое число: ");
int a=int.Parse(Console.ReadLine());
Console.Write ("Введите второе число: ");
int b=int.Parse(Console.ReadLine());

int sqrA=Convert.ToInt32(Math.Pow(a,2));

if (b==sqrA)
{
    Console.WriteLine ($"Второе число {b} является квадратом первого {a}");
}
else
{
    Console.WriteLine ($"Второе число {b} не является квадратом первого {a} (его квадрат = {sqrA})");
}