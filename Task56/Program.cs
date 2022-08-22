Console.Write("Введите количество строк: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
Console.Write("Введите количество столбцов: ");
int m = Convert.ToInt32(Console.ReadLine());

int[,] matrix = new int[n, m];
int sum = 0;


for (int i = 0; i < n; i++) {
    for (int j = 0; j < m; j++) {
        matrix[i, j] = new Random().Next(1, 30); 
        Console.Write(matrix[i, j] + "\t");
    }
    Console.WriteLine();
}

Console.WriteLine();
int[] min_sum = new int[n];

for (int i = 0; i < n; i++) 
{
    for (int j = 0; j < m; j++) 
    {
        sum = sum + matrix[i, j];
    }
    min_sum[i] = sum;
    sum = 0;

}

int min = min_sum[0];
int min_i = 0;

for (int i = 0; i < n; i++) 
{
    if (min_sum[i] < min)
    {
        min = min_sum[i];
        min_i = i;
    }
}

 Console.WriteLine("Минимальная сумма: " + min);

 Console.WriteLine(min_i+1 + " строка"); 
