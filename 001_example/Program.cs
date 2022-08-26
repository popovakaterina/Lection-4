string [,]table = new string [2,5];
table [1,2] = "word";
for (int rows = 0; rows < 2; rows ++) // распечатать массив
{
    for (int columns = 0; columns <5; columns++)
    {
        Console.Write($"-{table[rows,columns]}-"); // вывод массива
    }
Console.WriteLine();
}
Console.WriteLine("Следующий массив");

int[,] matrix = new int [3,4];
for (int rows = 0; rows < 3; rows ++) // распечатать массив
{
    for (int columns = 0; columns <4; columns++)
    {
        Console.Write($"{matrix[rows,columns]} "); // вывод массива
    }
Console.WriteLine();
}