int n = 4;

int[,] a = new int[n, n];
int[,] b = new int[n, n];
int[,] res = new int[n, n];

Console.WriteLine("Двумерный массив А: ");

for (int i = 0; i < n; i++) {
    for (int j = 0; j < n; j++) {
        a[i, j] = new Random().Next(1, 30); 
        Console.Write(a[i, j] + "\t");
    }
    Console.WriteLine();
}

Console.WriteLine("Двумерный массив B: ");

for (int i = 0; i < n; i++) {
    for (int j = 0; j < n; j++) {
        b[i, j] = new Random().Next(1, 30); 
        Console.Write(b[i, j] + "\t");
    }
    Console.WriteLine();
}

for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n; j++)
    {
        for (int k = 0; k < n; k++)
        {
            res[i,j] += a[i,k] * b[k,j];

        }
    }
}

Console.WriteLine("Произведение двух массивов: ");
for (int i = 0; i < n; i++) {
    for (int j = 0; j < n; j++) {
        Console.Write(res[i, j] + "\t");
    }
    Console.WriteLine();
}
