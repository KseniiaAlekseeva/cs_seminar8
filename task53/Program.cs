// Create a two-dimensional array. Swap first and last rows in the array

double[,] CreateArray(int m, int n, double minValue, double maxValue)
{
    double[,] array = new double[m, n];
    for (int i = 0; i < m; i++)
        for (int j = 0; j < n; j++)
            array[i, j] = new Random().NextDouble() * (maxValue - minValue) + minValue;
    return array;
}

void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(Math.Round(array[i, j], 2) + " ");
        Console.WriteLine();
    }
}

void SwapRows(double[,] array, int i1, int i2)
{
    bool flag1 = false;
    bool flag2 = false;
    if ((i1 >= 0) && (i1 < array.GetLength(0)))
        flag1 = true;
    if ((i2 >= 0) && (i2 < array.GetLength(0)))
        flag2 = true;

    if (!flag1)
        Console.WriteLine($"There is no row with index {i1} in this array.");
    if (!flag2)
        Console.WriteLine($"There is no row with index {i2} in this array.");

    if (flag1 && flag2)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            double cur = array[i1, j];
            array[i1, j] = array[i2, j];
            array[i2, j] = cur;
        }
    }
    PrintArray(array);
}

Console.WriteLine("Enter the dimension m*n of array: ");
string[] str = Console.ReadLine().Split(" ");

int m = Convert.ToInt32(str[0]);
int n = Convert.ToInt32(str[1]);

double[,] arr = CreateArray(m, n, -9.9, 9.9);
PrintArray(arr);
Console.WriteLine();

int i1 = 0;
int i2 = arr.GetLength(0) - 1;
SwapRows(arr, i1, i2);


