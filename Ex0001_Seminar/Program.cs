void FillArray(int[] array)
{
    int lenght = array.Length;
    int index = 0;
    while (index < lenght)
    {
        array[index] = new Random().Next(1, 10);
        Console.WriteLine(array[index]);
        index++;
    }
}
void FindMaxMin(int[] list)
{
    int lenght = list.Length;
    int index = 0;
    int max = list[0];
    int min = list[0];
    int indmax = 0;
    int indmin = 0; 
    while (index < lenght)
    {
        if(list[index] > max)
        {
            max = list[index]; 
            indmax = index;
        }
        if(list[index] < min)
        {
            min = list[index];
            indmin = index;
        }
        index++;
    }
   Console.WriteLine($"Максимальное число: {max}");
   Console.WriteLine($"Индекс максимального числа: {indmax}");
   Console.WriteLine($"Минимально число: {min}");
   Console.WriteLine($"Индекс минимального числа: {indmin}");
}

int[] array = new int[10];
FillArray(array);
FindMaxMin(array);
