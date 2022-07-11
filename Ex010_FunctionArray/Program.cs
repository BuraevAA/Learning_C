int[] array = {111, 22, 33, 54, 33, 652, 76, 824};

int n = array.Length;
int find = 33;

int index = 0;

while (index < n)
{
    if(array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    //index=index+1;
    index++;
}
