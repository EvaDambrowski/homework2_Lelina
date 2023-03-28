//Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
Console.WriteLine("Введите число от 1 до 7");
int day = int.Parse(Console.ReadLine()!);
int monday = 1;
int tuesday = 2;
int wednesday = 3;
int thursday = 4;
int friday = 5;
int saturday = 6;
int sunday = 7;

if (day == 6 || day ==7)
{
    Console.WriteLine($"День {day} является выходным днем"!);
}
else
{
    Console.WriteLine($"День {day} НЕ является выходным днем"!);

}