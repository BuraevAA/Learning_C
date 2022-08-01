Console.WriteLine("Введите число програмистов: ");
int num = Convert.ToInt32(Console.ReadLine());

string a = "программист";
string b = "программиста";
string c = "программистов";

if(num == 1)
{
    Console.Write($"{num} {a}");
}

else if(num > 1 && num < 5)
{
    Console.Write($"{num} {b}");
}
else if(num > 5 && num < 20)
{
    Console.Write($"{num} {c}");
}
