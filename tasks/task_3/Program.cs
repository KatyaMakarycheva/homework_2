// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

Console.WriteLine("Введите номер дня недели: ");

int[] array = {1, 2, 3, 4, 5, 6, 7}; 
int d = Convert.ToInt32(Console.ReadLine());

if (d == 6 || d == 7)
{
  Console.WriteLine("Это выходной");
}
else 
{
   Console.WriteLine("Это рабочий день");
}
