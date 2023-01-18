Console.WriteLine("Введите число ");
int num = int.Parse(Console.ReadLine());
int res = 1;
while (res < num)
{
    Console.WriteLine(res + 1);
    res += 2;
}    