Console.Clear();
Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
if (a<100)
{
        Console.Write("Вы ошиблись!\nВведите трёхзначное число: ");
}
else if (a>999)
{
        Console.Write("Вы ошиблись!\nВведите трёхзначное число: ");
}
else
{
int a1 = a/10;
int a2 = a1%10;
Console.WriteLine (a2); 
}
