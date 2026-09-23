int i = 0;
do
{
    Console.Write(i);
    i--;
}
while (i > 0);


int n = 0;
    while  (n > 0)
{
    Console.Write(n);
    n--;
}


Console.Write("\n");
long v = Convert.ToInt64(Console.ReadLine());

long w = 1;
while (w <= v)
{
    Console.Write(w + " ");
    w *= 2;
}
Console.WriteLine();


Console.Write("\n");
int count = Convert.ToInt32(Console.ReadLine());

long first = 0;
long second = 1;

int p = 0;
while (p < count)
{
    Console.Write(first + " ");

    long next = first + second;
    first = second;
    second = next;

    p++;
}
Console.WriteLine();