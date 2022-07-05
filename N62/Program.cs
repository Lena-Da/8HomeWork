// Заполните спирально массив 4 на 4.

int[,] array = new int[4, 4];

int temp = 1;
int i = 0;
int j = 0;

while (temp <= 4 * 4)
{
  array[i, j] = temp;
  temp++;
  if (i <= j + 1 && i + j < 4 - 1)
    j++;
  else if (i < j && i + j >= 4 - 1)
    i++;
  else if (i >= j && i + j > 4 - 1)
    j--;
  else
    i--;
}

WriteArray(array);

void WriteArray (int[,] array)
{
  for (int i = 0; i < 4; i++)
  {
    for (int j = 0; j < 4; j++)
    {
      if (array[i,j] / 10 <= 0)
      Console.Write($" {array[i,j]} ");

      else Console.Write($"{array[i,j]} ");
    }
    Console.WriteLine();
  }
}