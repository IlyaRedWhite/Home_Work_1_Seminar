// Найти максимальное число из трех 
int a = 6;
int b = 2;
int c = 7;

int max = a;

if ( a > max ) max = a;
if ( b > max ) max = b;
if ( c > max ) max = c;

Console.WriteLine("max = ");
Console.WriteLine(max);
