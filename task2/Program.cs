// Задача 2: Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. 
//В случае, если это невозможно, программа должна 
//вывести сообщение для пользователя.

int Promt(string msg)
{
  System.Console.Write(msg + "-> ");
  return int.Parse(Console.ReadLine());
}

int[,] CreateArray(int lenghtStr, int lenghtCol)
{
  int[,] array = new int[lenghtStr, lenghtCol];
  Random rnd = new Random();
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      array[i, j] = rnd.Next(10);
    }
  }
  return array;
}

void Check(int[,] array)
{
  if (array.GetLength(0) != array.GetLength(1))
  {
    System.Console.WriteLine("Количество колонок не равно количеству столбцов. Операция невозможна.");
    Environment.Exit(1);
  }
}

void PrintArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      System.Console.Write(array[i, j] + "; ");
    }
    System.Console.WriteLine();
  }
}

int[,] Transponate(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = i; j < array.GetLength(1); j++)
    {
      int temp = array[i, j];
      array[i, j] = array[j, i];
      array[j, i] = temp;
    }
  }
  return array;
}

int lenStr = Promt("Введите количество строк");
int lenCol = Promt("Введите колтчеств столбцов");
int[,] myArray = CreateArray(lenStr, lenCol);
Check(myArray);
PrintArray(myArray);
System.Console.WriteLine();
PrintArray(Transponate(myArray));