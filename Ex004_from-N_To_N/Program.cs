// Написать программу, которая принимает N и показывает все числа от -N до N

Console.Write ("Введите N:");
int N=int.Parse(Console.ReadLine());

int i=-N;

while (i<=N)
{
    Console.WriteLine(i);
    i++;
}
