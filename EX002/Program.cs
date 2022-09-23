// В двумерном массиве nxk заменить четные элементы на противоположные

void PrintArray(int [,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i,j]} ");
        }
    Console.WriteLine();
    }
}
void fillArray(int [,] array, int min, int max)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = new Random().Next(min, max);
        }
    }
}
void Processing(int [,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for( int j = 0; j < array.GetLength(1); j++)
        {
            if(array[i,j] % 2 == 0)
            {
            array[i,j] = array[i,j] * -1;
            }
        }
    }
}

Console.WriteLine("Введите количество строк в массиве: ");
int n = int.Parse(Console.ReadLine() ??"0");
Console.WriteLine("Введите количество столбцов в массиве: ");
int k = int.Parse(Console.ReadLine() ??"0");

int[,] array = new int[n,k];
fillArray(array, 10, 100);
PrintArray(array);
Console.WriteLine();
Processing(array);
PrintArray(array);