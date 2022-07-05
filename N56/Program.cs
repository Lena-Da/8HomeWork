// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

int[,] array = new int[4, 8];
ArrayInt(array);
int MinSum = 0;
int Sum = SumElementsLine(array, 0);


int SumElementsLine(int[,] array, int i)
{
  int sumLine = array[i,0];
  for (int j = 1; j < 8; j++)
  {
    sumLine += array[i,j];
  }
  return sumLine;
}

for (int i = 1; i < 4; i++)
{
  int tempSumLine = SumElementsLine(array, i);
  if (Sum > tempSumLine)
  {
    Sum = tempSumLine;
    MinSum = i;
  }
}

Console.WriteLine($"\n{MinSum+1} - строкa с наименьшей суммой  элементов. Сумма равна: {Sum}.");



void ArrayInt(int[,] array)
{
for (int i = 0; i < 4; i++)
  {
    for (int j = 0; j < 8; j++)
    {
      array[i, j] = new Random().Next(1, 10);
      Console.Write(array[i, j] + " ");
    }
    Console.WriteLine();
  }
}
