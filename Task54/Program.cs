Console.Write("Введите количество строк: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
Console.Write("Введите количество столбцов: ");
int m = Convert.ToInt32(Console.ReadLine());

int[,] matrix = new int[n, m];
int s = 0;

for (int i = 0; i < n; i++) 
{
    for (int j = 0; j < m; j++) {
        matrix[i, j] = new Random().Next(1, 30); 
        Console.Write(matrix[i, j] + "\t");
    }
    Console.WriteLine();
}

for (int i = 0; i < n; i++) 
{
    for (int j = 0; j < m - 1; j++) 
    {
        for (int k = j + 1; k < m; k++)
        {
            if (matrix[i, j] < matrix[i, k]) 
            {
                s = matrix[i, j];
                matrix[i, j] = matrix[i, k];
                matrix[i, k] = s;
            }
        }
    }
}
 Console.WriteLine();

for (int i = 0; i < n; i++) 
{
    for (int j = 0; j < m; j++) 
    {
        Console.Write(matrix[i, j] + "\t");
    }
    Console.WriteLine();
}