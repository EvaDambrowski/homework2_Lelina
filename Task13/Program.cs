// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.WriteLine("Введите трехзначное число: ");
int num = int.Parse(Console.ReadLine()!);

if (num  / 100 > 0 )
{
   //int digit = num / 10;
   int digit = num % 10;
    Console.WriteLine(digit);
}
else
{
    Console.WriteLine("Третьей цифры нет");
}


