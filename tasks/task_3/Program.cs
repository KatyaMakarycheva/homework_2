// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

Console.WriteLine("Введите номер дня недели: ");

int[] array = {1, 2, 3, 4, 5, 6, 7};
int d = array.Length:
int day = Convert.ToInt32(Console.ReadLine());

if(d >= 6)
    { 
        Console.WriteLine("Это выходной день");
    }
 else if(d < 6)
 {
    Console.WriteLine("Это рабочий день");
 }

 else(d > 7)
 {
    Console.WriteLine("Такого дня недели нет");
 }