Console.WriteLine(Sum(20));

int n = 20;
int m = 30;
Console.WriteLine($"{n} {m}");
Swap(ref n, ref m);
Console.WriteLine($"{n} {m}");

int[] array = { 1, 2, 3, 4, 5 };
int sum;
SumArray(array, out sum);
Console.WriteLine();

int Sum(int a,  int b = 0)
{
    int result = a + b;
    return result;
}

long factorial(int n)
{
    if (n == 0) return 1;
    return factorial(n - 1) * n;
}

void SayHello(string name) => Console.WriteLine($"Hello {name}");

/*
int Mult(int a, int b)
{
    return a * b;
}
*/
int Mult(int a, int b) => a * b;

void Swap(ref int a, ref int b)
{
    int temp = a; a = b; b = temp;
}

void SumArray(int[] array, out int sum)
{
    sum = 0;
    foreach (int item in array) sum += item;
}

void func(in int n)
{

}

enum WayType
{
    Up, 
    Down,
    Left,
    Right,
}

enum Region
{
    Tula = 71,
    Irkutsk = 38
}

