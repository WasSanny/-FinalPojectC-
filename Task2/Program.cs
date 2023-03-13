// Задайте значения M и N. Напишите программу, которая найдёт
// сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Clear();
Task1();

void Task1()
{
  int a = ReadInt("Введите число M: ");
  int b = ReadInt("Введите число N: ");

  int sum =0;

    if(b < a)
    {
      a = b + a;
      b = a - b;
      a = a - b;
    }
  int res = SumElementForMAndN(a, b, sum);
  Console.WriteLine($"Сумма элементов в промежутке от M до N равна: {res}");
}

int ReadInt(string argument1)
{
  Console.Write($"{argument1}");
  int number;

  while(!int.TryParse(Console.ReadLine(), out number))
  {
    Console.WriteLine("Try again!");
  }
    
  return number; 
}

int SumElementForMAndN(int a, int b, int sum)
{
  if (a < b || b != a-1) 
  {
    return sum += b + SumElementForMAndN(a, b-1, sum); 
  }
  else return sum;

}
