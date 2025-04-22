int size = 10;

int[] array = new int[size];
//int[] array2 = new int[] { 10, 20, 30, 40 };
//int[] array3 = new[] { 10, 20, 30 };
//int[] array4 = {1, 2, 3, 4, 5, 6 };

Random random = new Random();
for (int i = 0; i < array.Length; i++)
    array[i] = random.Next(0, 99);

for (int i = 0; i < array.Length; i++)
    Console.Write($"{array[i]} ");
Console.WriteLine();

foreach(int item in array)
    Console.Write($"{item} ");
Console.WriteLine("\n");

int width = 8;
int height = 5;

int[,] matrix = new int[height, width];

for (int i = 0; i < matrix.GetLength(0); i++)
    for (int j = 0; j < matrix.GetLength(1); j++)
        matrix[i, j] = random.Next(10, 99);

for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
        Console.Write($"{matrix[i, j]} ");
    Console.WriteLine();
}
Console.WriteLine("\n");

int rows = 4;
int[][] ztable = new int[rows][];

for (int i = 0; i < ztable.Length; i++)
    ztable[i] = new int[random.Next(5, 10)];

for (int i = 0; i < ztable.Length; i++)
    for (int j = 0; j < ztable[i].Length; j++)
        ztable[i][j] = random.Next(10, 99);

for (int i = 0; i < ztable.Length; i++)
{
    for (int j = 0; j < ztable[i].Length; j++)
        Console.Write($"{ztable[i][j]} ");
    Console.WriteLine();
}
    


    