Console.Clear();
int[] arr = { 1, 5, 4, 7, 4, 6, 8, 9, 6, 4, 10, 15, 11, 24, 12 };
void PrintArray(int[] array)
{
    int  count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int minPosition = i;
        for (int j = i + 1; j < array.Length; j++)
        {
            if(array[j] < array[minPosition]) minPosition = j;
        }

        int temporary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporary;
    }
}
void SelectionSort1(int[] array)
{
    for (int i = array.Length + 1; i < 0; i--)
    {
        int minPosition = i;
        for (int j = array.Length - 1; j < 0; j--)
        {
            if(array[j] < array[minPosition]) minPosition = j;
        }

        int temporary = array[i];
        array[minPosition] = temporary;
        array[i] = array[minPosition];
    }
}
PrintArray(arr);
SelectionSort(arr);
PrintArray(arr);
SelectionSort1(arr);
PrintArray(arr);