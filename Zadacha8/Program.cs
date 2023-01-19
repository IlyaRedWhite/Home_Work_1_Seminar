Console.WriteLine("Введите число ");
int num = int.Parse(Console.ReadLine());
int res = 1;
while (res < num)
{
    Console.Write(res + 1 +", ");
    res += 2;
}    
