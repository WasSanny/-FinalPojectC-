// Задайте значение N. Напишите программу, которая выведет все натуральные числа
// в промежутке от N до 1. Выполнить с помощью рекурсии.

Console.Clear();
Console.WriteLine(NaturalNumber(ReadInt("")));

int ReadInt(string argument)
{
  Console.Write($"Введите натуральное число: {argument}");
  int number;
 
  while(!int.TryParse(Console.ReadLine(), out number))
  {
    Console.WriteLine("Try again!");
  }

  Console.Write($"Вы ввели число {number}, результат -> ");
  return number; 
}

int NaturalNumber(int a)
{
  if (a > 1 ) 
  { 
    Console.Write($"{a}, ");
    return  NaturalNumber(a-1); 
  }
  
  else return 1;
}