//Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
Console.WriteLine("Введите трехзначное число: ");
int num = int.Parse(Console.ReadLine()!);

if (num % 10 > 0 )
{
    int digit = num / 10;
    int secondDigit = digit % 10;
    Console.WriteLine(secondDigit);
}
else
{
    Console.WriteLine("Введено не трехзначное число");
}

