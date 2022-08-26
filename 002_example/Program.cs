// Печать матрицы и заполнение ее числами
void PrintArray(int [,] matr) // Метод распечатки массива
{
    for (int i = 0; i < matr.GetLength(0); i++) // распечатать массив
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} "); // вывод массива
        }
        Console.WriteLine();
    }
}


void FillArraay (int [,] matr) // Заполение массива случайными числамии
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i,j] = new Random ().Next(1,10);

        }
    }
}
int [,] matrix = new int [3,4];

PrintArray(matrix);
FillArraay (matrix);
Console.WriteLine();
PrintArray(matrix);