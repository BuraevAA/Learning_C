//Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
//[1 2 3 4 5] -> 5 8 3
//[6 7 3 6] -> 36 21

int[] list = new int[13];
string result = String.Empty;

for (int i = 0; i < list.Length; i++)
{
    list[i] = new Random().Next(1, 20);
}

void PrintArray(int[] col)
    {
        int count = col.Length;
        int position = 0;
        while (position < count)
            {
                Console.Write($"{col[position]} ");
                position++;
            }
    }
PrintArray(list);
Console.WriteLine();
for (int i = 0; i < list.Length / 2; i++)
{
    result += $"{list[i] * list[list.Length - i - 1]}, ";
}
if (list.Length % 2 != 0) result += $"{list[list.Length / 2]}";

Console.WriteLine(result);






