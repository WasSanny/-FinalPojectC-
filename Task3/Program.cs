// Напишите программу вычисления функции Аккермана с помощью рекурсии.
// Даны два неотрицательных числа m и n.

// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29
 
Console.Clear();

int number1 = ReadInt("Введите первое число: ");
int number2 = ReadInt("Введите второе число: ");

Console.WriteLine();
Console.WriteLine($"Результат ф-ии Аккермана равен: {Akkerman(number1, number2)}");
Console.WriteLine();


int ReadInt(string argument)
{
  Console.Write($"{argument}");
  int number;

  while(!int.TryParse(Console.ReadLine(), out number))
  {
    Console.WriteLine("Try again!");
  }
    
  return Math.Abs(number);
}

int Akkerman(int a, int b)
{
  if( a == 0) return b + 1;
  else if(a != 0 && b == 0) return Akkerman(a - 1, 1);
  else return Akkerman(a - 1, Akkerman(a, b - 1));
}