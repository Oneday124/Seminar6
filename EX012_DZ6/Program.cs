// Написать программу, которая в двумерном массиве меняет строки на столбцы или сообщить что это не возможно (если матрица не квадратная)

void PrintMatrix(int[,] matrix)
{
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i,j]} ");
        }
    Console.WriteLine();
    }
}
void FillMatrix(int[,] matrix, int min, int max)
{
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = new Random().Next(min, max);
        }
    }
}
int[,] Transposition(int[,] matrix)
{
    int[,] transposition = new int[matrix.GetLength(0),matrix.GetLength(1)];
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            transposition[i,j] = matrix[j,i];
        }
    }
    return transposition;
}

Console.WriteLine("Введите количество строк в матрице: ");
int m = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Введите количество столбцов в матрице: ");
int n = int.Parse(Console.ReadLine() ?? "0");

int[,] matrix = new int[m,n];
FillMatrix(matrix, 1,10);
PrintMatrix(matrix);
Console.WriteLine();
if(m == n)
{
    int[,] transposition = Transposition(matrix);
    PrintMatrix(transposition);
}
else
{
    Console.WriteLine("Матрица не квадратная, транспонировать не возможно! ");
}