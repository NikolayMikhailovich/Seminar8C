// Задача 3: Составить частотный словарь элементов двумерного массива. 
// Частотный словарь содержит информацию о том, сколько раз
//  встречается элемент входных данных. Значения элементов массива 0..9

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
int[] FrequencyDict(int[,] array)
{
  int[] freqDict = new int[10];
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int x = 0; x < array.GetLength(1); x++)
    {
      freqDict[array[i, x]]++;
    }
  }
  return freqDict;
}

void PrintDict(int[] array)
{
  for (int i = 0; i < array.Length; i++)
  {
    System.Console.Write($"{i} - {array[i]}; ");
  }
}

int lenStr = Promt("Введите количество строк");
int lenCol = Promt("Введите колтчеств столбцов");
int[,] myArray = CreateArray(lenStr, lenCol);
PrintArray(myArray);
System.Console.WriteLine();
int[] freqDict = FrequencyDict(myArray);
PrintDict(freqDict);