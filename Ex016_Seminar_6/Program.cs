/*Задача 45: c клавиатуры задается размерность двумерного массива, найти максимум и его индекс, найти минимум и его индекс, найти среднее арифметическое
причем надо обязательно вывести двумерный массив на экран

*/
Console.Clear();
Console.WriteLine("Введите колличество строк массива");
int i = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите колличество столбцов массива");
int j = Convert.ToInt32(Console.ReadLine());
void FillPrintArray(int[,] matr)
{
        for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i,j] = new Random().Next(1,10);
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}

int[,] matrix = new int[i, j];
FillPrintArray(matrix);
int matrixmin = matrix[0,0];
int indexminrow = 0;
int indexmincow = 0;
int indexmaxrow = 0;
int indexmaxcow = 0;
int midl = 0;
int matrixmax = matrix[0,0];
for (int row = 0; row < matrix.GetLength(0); row++)
{
    for (int cow = 0; cow < matrix.GetLength(1); cow++)
    {
        if (matrix[row,cow] < matrixmin)
        {
            matrixmin = matrix[row,cow];
            indexminrow = row;
            indexmincow = cow;
        }
        else if (matrix[row,cow] > matrixmax)
        {
            matrixmax = matrix[row,cow];
            indexmaxrow = row;
            indexmaxcow = cow;
        }
        midl = (midl + matrix[row,cow]);
    }
}
midl = midl/(i*j);

Console.WriteLine($"Максимальное число: {matrixmax}");
Console.WriteLine($"Индекс максимального числа: {indexmaxrow},{indexmaxcow}");
Console.WriteLine($"Минимально число: {matrixmin}");
Console.WriteLine($"Индекс минимального числа: {indexminrow},{indexmincow}");
Console.WriteLine($"Среднее арифметическое: {midl}");