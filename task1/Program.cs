// Задача 1: Задайте двумерный массив. Напишите программу, 
//которая поменяет местами первую и последнюю строку массива.

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

int[,] ChangeLastAndFirstStr(int[,] array)
{
  int lastStr = array.GetLength(0) - 1;
  for (int j = 0; j < array.GetLength(1); j++)
  {
    int temp = array[0, j];
    array[0, j] = array[lastStr, j];
    array[lastStr, j] = temp;
  }
  return array;
}

int lenStr = Promt("Введите количество строк");
int lenCol = Promt("Введите колтчеств столбцов");
int[,] myArray = CreateArray(lenStr, lenCol);
PrintArray(myArray);
myArray = ChangeLastAndFirstStr(myArray);
System.Console.WriteLine();
PrintArray(myArray);