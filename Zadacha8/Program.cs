//Найти все четные числа от 1 до N

int oddNumbersCount = 0; //нечетные числа
int evenNumbersCount = 0; //четные числа

Console.WriteLine("Введите число ");
int currentValue = 1;
int N = int.Parse(Console.ReadLine());

while (currentValue <= N )
{
    if (currentValue % 2 == 0)
    {
        evenNumbersCount++;
    }
    else
    {
        oddNumbersCount++;
    }
currentValue++;
}




Console.WriteLine("Количество четных чисел: " + evenNumbersCount);
