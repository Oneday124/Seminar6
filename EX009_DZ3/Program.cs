//  Дан целочисленный массив. Найти среднее арифметическое каждого из столбцов
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
double Average(int[,] matrix, int j)
{
    double sum = 0;
    int i = 0;
    while(i < matrix.GetLength(0))
    {
        sum = sum + matrix[i,j];
        i++;
    }
    double average = sum / matrix.GetLength(0);
    return average;
}

Console.WriteLine("Введите количество строк в матрице: ");
int m = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Введите количество столбцов в матрице: ");
int n = int.Parse(Console.ReadLine() ?? "0");

int[,] matrix = new int[m, n];
FillMatrix(matrix, 1,10);
PrintMatrix(matrix);
Console.WriteLine();
for(int j = 0; j < matrix.GetLength(1); j++)
{
    double average = Average(matrix, j);
    Console.WriteLine($"Cреднее арифметическое по столбцу {j} = {average} ");
}