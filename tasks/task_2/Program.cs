// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.Write("Введи число: ");
int Number = Convert.ToInt32(Console.ReadLine());
string NumberNew = Convert.ToString(Number);

if (NumberNew.Length > 2)
{
  Console.WriteLine(NumberNew[2]);
}

else 
{
  Console.WriteLine("третьей цифры нет");
}



