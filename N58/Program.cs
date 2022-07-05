// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

int[,] array = new int[5, 10];
int[,] array2 = new int[5, 10];
FirstArray(array);
SecondArray(array2);
int[,] ResultArray = new int[5, 10];
int j;

for (int i = 0; i < 5; i++)
{
for (j = 0; j < 10; j++)
    {
        ResultArray[i, j] = array[i, j] * array2[i, j];
        Console.Write(ResultArray[i, j] + " ");
    }
    Console.WriteLine();
    j = 0;
}

void FirstArray(int[,] array)
{
for (int i = 0; i < 5; i++)
  {
    for (int j = 0; j < 10; j++)
    {
      array[i, j] = new Random().Next(1, 10);
      Console.Write(array[i, j] + " ");
    }
    Console.WriteLine();
  }
Console.WriteLine();
}


void SecondArray(int[,] array)
{
for (int i = 0; i < 5; i++)
  {
    for (int j = 0; j < 10; j++)
    {
      array2[i, j] = new Random().Next(1, 10);
      Console.Write(array2[i, j] + " ");
    }
    Console.WriteLine();
  }
Console.WriteLine();
}