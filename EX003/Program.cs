// В двумерном массиве показать позиции числа, заданного пользователем или указать, что такого элемента нет

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
void Search(int[,] matrix, int num)
{
    int search = 0;
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            if(matrix[i,j] == num) 
            {
                Console.WriteLine($"Позиция {num}: [{i},{j}]");
                search = matrix[i,j];
            }
        }
    }
    if(search == 0)
    {
        Console.WriteLine($"Элемента {num} нет в массиве");
    }
}

int [,] matrix = new int[5,5];
FillMatrix(matrix, 1, 10);
PrintMatrix(matrix);
Console.WriteLine("Введите значение элемента массива: ");
int number = int.Parse(Console.ReadLine() ?? "0");
Search(matrix, number);

