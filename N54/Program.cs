// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

int[,] array = new int[4, 5];
ArrayInt(array);
OrderArray(array);
NewArray(array);

void OrderArray(int[,] array)
{
  for (int i = 0; i < 3; i++)
  {
    for (int j = 0; j < 4; j++)
    {
      for (int k = 0; k < 5 - 1; k++)
      {
        if (array[i, k] < array[i, k + 1])
        {
          int temp = array[i, k + 1];
          array[i, k + 1] = array[i, k];
          array[i, k] = temp;
        }
      }
    }
  }
Console.WriteLine();}



void NewArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      Console.Write(array[i, j] + " ");
    }
    Console.WriteLine();
  }
}

void ArrayInt(int[,] array)
{
for (int i = 0; i < 4; i++)
  {
    for (int j = 0; j < 5; j++)
    {
      array[i, j] = new Random().Next(1, 50);
      Console.Write(array[i, j] + " ");
    }
    Console.WriteLine();
  }
}
