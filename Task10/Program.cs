Console.WriteLine("Введите трехзначное число: ");
int num = int.Parse(Console.ReadLine()!);

if (num  / 100 > 0 )
{
   int digit = num / 10;
   int secondDigit = digit % 10;
    Console.WriteLine(secondDigit);
}
else
{
    Console.WriteLine("Введено не трехзначное число");
}