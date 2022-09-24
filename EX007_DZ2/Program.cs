// Задать двумерный массив следующим правилом А = m + n
void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
}
void FillMatrix(int[,] matrix, int m, int n)
{
    int A = m + n;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = A;
        }
    }
}

Console.WriteLine("Введите количество строк в массиве: ");
int m = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Введите кличество столбцов в массиве: ");
int n = int.Parse(Console.ReadLine() ?? "0");

int[,] matrix = new int[m,n];
FillMatrix(matrix, m, n);
PrintMatrix(matrix);