int a = 5;
int b = 3;
int c = 7;
int d = 1;

int max = a;

if (b > max)
{
    max = b;
}
if (c > max)
{
    max = c;
}
if (c > max)
{
    max = d;
}
System.Console.WriteLine(max);