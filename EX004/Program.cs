// В матрице чисел найти сумму главной диагонали

void FillMatrix(int[,] matrix, int min, int max)
{
    for(int i = 0; i < matrix.GetLength(0); i++)
        for(int j = 0; j < matrix.GetLength(1); j++)
            matrix[i,j] = new Random().Next(min, max);

}
void PrintMatrix(int[,] matrix)
{
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
            Console.Write($"{matrix[i,j]} ");
        Console.WriteLine();
    }
}
void SumMatrix(int[,] matrix)
{
    int sum = 0;
    for(int i = 0; i< matrix.GetLength(0); i++)
    {
        sum = sum + matrix[i,i];
    }
    Console.Write($"Сумма элементов массива по диагонали = {sum}");
}
Console.WriteLine("Введите размерность матрицы nxn: ");
int n = int.Parse(Console.ReadLine() ??"0");

int [,] matrix = new int[n,n];
FillMatrix(matrix, 1, 10);
PrintMatrix(matrix);
SumMatrix(matrix);