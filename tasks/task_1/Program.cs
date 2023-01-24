// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

Console.Write("введите трехзначное число");

int Number = Convert.ToInt32(Console.ReadLine());

while(Number >= 100)
{
    Number = Number / 10; 
}

int result = Number % 10;

Console.WriteLine(result);
