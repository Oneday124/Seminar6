// Показать двумерный массив размером mxn заполненный целыми числами
void FillArray(int [,] array, int m, int n)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = new Random().Next(1,10);
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}


Console.WriteLine("Введите количество строк в массиве: ");
int m = int.Parse(Console.ReadLine() ??"0");
Console.WriteLine("Введите количество столбцов в массиве: ");
int n = int.Parse(Console.ReadLine() ??"0");

int[,] array = new int[m,n];
FillArray(array, m, n);