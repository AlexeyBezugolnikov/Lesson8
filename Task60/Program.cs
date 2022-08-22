int n = 2;

int[,,] matrix = new int[n, n, n];

Console.WriteLine("Трехмерный массив: ");

for (int i = 0; i < n; i++) 
{
    for (int j = 0; j < n; j++) 
    {
        for (int k = 0; k < n; k++) 
        {
            matrix[i, j, k] = new Random().Next(10, 100); 
            Console.Write(matrix[i, j, k] + " (" + i + ", " + j + ", " + k + ")" + "\t");
        }
    }
    Console.WriteLine();
}
