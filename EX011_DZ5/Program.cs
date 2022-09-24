// Написать программу, упорядочивания по убыванию элементов каждой строки двумерного массива

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
void Sort(int[,] matrix)
{
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1)-1; j++)
        {
            int minPosition = j;
            for(int ind = j + 1; ind < matrix.GetLength(1); ind++)
            {
                if(matrix[i, ind] > matrix[i, minPosition]) minPosition = ind;
            }
            int temporary = matrix[i,j];
            matrix[i,j] = matrix[i, minPosition];
            matrix[i, minPosition] = temporary;
        }
    }
}

Console.WriteLine("Введите количество строк в матрице: ");
int m = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Введите количество столбцов в матрице: ");
int n = int.Parse(Console.ReadLine() ?? "0");

int[,] matrix = new int[m,n];
FillMatrix(matrix, 1,10);
PrintMatrix(matrix);
Console.WriteLine();
Sort(matrix);
PrintMatrix(matrix);