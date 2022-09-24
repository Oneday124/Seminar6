// В двумерном массиве заменить элементы, у которых оба индекса четные на их квадраты
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
void Processing (int[,] matrix)
{
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            if(i % 2 == 0 && j % 2 == 0)
            {
                matrix[i,j] = matrix[i,j] * matrix[i,j];
            } 
        }
    }    
}
Console.WriteLine("Введите количество строк в матрице: ");
int m = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Введите количество столбцов в матрице: ");
int n = int.Parse(Console.ReadLine() ?? "0");

int[,] matrix = new int[m,n];
FillMatrix(matrix, 1, 10);
PrintMatrix(matrix);
Console.WriteLine();
Processing(matrix);
PrintMatrix(matrix);