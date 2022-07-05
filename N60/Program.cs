// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, 
// которая будет построчно выводить массив, добавляя индексы каждого элемента.

int[,,] array3d = new int[3, 4, 5];
ArrayInt(array3d);
NewArray(array3d);

void NewArray (int[,,] array3d)
{
  for (int i = 0; i < 3; i++)
  {
    for (int j = 0; j < 4; j++)
    {
    Console.Write($"x{i} y{j} ");
    for (int k = 0; k < 5; k++)
      {
        Console.Write( $"z{k}={array3d[i,j,k]}; ");
      }
    Console.WriteLine();
    }
    Console.WriteLine();
  }
}



void ArrayInt(int[,,] array)
{
for (int i = 0; i < 3; i++)
  {
    for (int j = 0; j < 4; j++)
    {
        for (int k = 0; k < 5; k++)
        {
         array[i, j, k] = new Random().Next(10, 31);
        Console.Write(array[i, j, k] + " ");
        }
    Console.WriteLine();
    }
Console.WriteLine();}
}
