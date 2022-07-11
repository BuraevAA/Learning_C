int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if(arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
}
int a1 = 12135;
int b1 = 16;
int c1 = 121;
int a2 = 115;
int b2 = 35;
int c2 = 4213;
int a3 = 37;
int b3 = 19;
int c3 = 132;

//int max1 = Max(a1, b1, c1);
//int max2 = Max(a2, b2, c2);
//int max3 = Max(a3, b3, c3);
//int max = Max(max1, max2, max3);

int max = Max(
    Max(a1, b1, c1), 
    Max(a2, b2, c2), 
    Max(a3, b3, c3));

Console.WriteLine(max);
