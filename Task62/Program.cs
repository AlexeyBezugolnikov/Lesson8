int n = 4;
int[,] matrix = new int[n, n];

int k = 1;
int i = 0;
int j = 0;

while (k <= matrix.GetLength(0) * matrix.GetLength(1))
{
  matrix[i, j] = k; 
  k++;
  if (i <= j + 1 && i + j < matrix.GetLength(1) - 1)
    j++;
  else if (i < j && i + j >= matrix.GetLength(0) - 1)
    i++;
  else if (i >= j && i + j > matrix.GetLength(1) - 1)
    j--;
  else
    i--;
}

for (i = 0; i < matrix.GetLength(0); i++)
  {
    for (j = 0; j < matrix.GetLength(1); j++)
    {
      Console.Write(matrix[i,j] + "\t");
    }
    Console.WriteLine();
  }