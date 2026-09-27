int a = Convert.ToInt32(Console.ReadLine());

int[] massiv = new int[a];

for (int i = 0; i < a; i++)
{
    massiv[i] = Convert.ToInt32(Console.ReadLine());

}

foreach (int i in massiv)
{
    Console.WriteLine(i);
}



Console.WriteLine();

int x = Convert.ToInt32(Console.ReadLine());
int[] arr = new int[x];

for (int i = 0; i < x; i++)
{
    if (i % 2 == 0)
    {
        arr[(x - 1 - i / 2)] = Convert.ToInt32(Console.ReadLine());
    }
    else
{
    arr[(i / 2)] = Convert.ToInt32(Console.ReadLine());
}
}

foreach (int i in arr)
{
    Console.WriteLine(i);
}




const int N = 10;
int[,] m = new int[N, N];
Random r = new Random();

for (int i = 0; i < N; i++)
    for (int j = 0; j < N; j++)
        m[i, j] = r.Next(1, 10);

int[] rowSum = new int[N];
long[] colMul = new long[N];

for (int j = 0; j < N; j++)
    colMul[j] = 1;

for (int i = 0; i < N; i++)
    for (int j = 0; j < N; j++)
    {
        rowSum[i] += m[i, j];
        colMul[j] *= m[i, j];
    }

int bestRow = 0, bestCol = 0;
for (int i = 1; i < N; i++)
{
    if (rowSum[i] > rowSum[bestRow]) bestRow = i;
    if (colMul[i] > colMul[bestCol]) bestCol = i;
}

Console.WriteLine(rowSum[bestRow]);
Console.WriteLine(colMul[bestCol]);