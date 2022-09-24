// Показать двумерный массив размером mxn, заполненный вещественными числами
void PrintMatrix(int[,] matrix)
{
    for(int i =0; i < matrix.GetLength(0); i++)
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

Console.WriteLine("Введите количество строк в массиве: ");
int m = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Введите кличество столбцов в массиве: ");
int n = int.Parse(Console.ReadLine() ?? "0");

int[,] matrix = new int[m,n];
FillMatrix(matrix, -100, 100);
PrintMatrix(matrix);
