// В прямоугольной матрице найти строку с наименьшей суммой элементов

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
void SumMin(int[,] matrix)
{
    int min = 0;
    int sumMatrix =0;
    for(int i =0;i<matrix.GetLength(0);i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            sumMatrix = sumMatrix + matrix[i,j];
            min = sumMatrix;
        }
    }
    int minPosition = 0;
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        int sum = 0;
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            sum = sum + matrix[i,j];
        }
        if(sum < min)
        {
            min = sum;
            minPosition = i; 
        }
    }
     Console.WriteLine($"Индекс строки с наименьшей суммой элементов: {minPosition} ");
}

Console.WriteLine("Введите количество строк в матрице: ");
int m = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Введите количество столбцов в матрице: ");
int n = int.Parse(Console.ReadLine() ?? "0");

int[,] matrix = new int[m,n];
FillMatrix(matrix, 1,10);
PrintMatrix(matrix);
Console.WriteLine();
SumMin(matrix);
