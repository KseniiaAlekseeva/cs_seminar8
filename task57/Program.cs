// Create a frequency dictionary of elements of a two-dimensional array

int[,] CreateArray(int m, int n, int minValue, int maxValue)
{
    int[,] array = new int[m, n];
    for (int i = 0; i < m; i++)
        for (int j = 0; j < n; j++)
            array[i, j] = new Random().Next(minValue, maxValue + 1);
    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + " ");
        Console.WriteLine();
    }
    Console.WriteLine();
}

void BubbleSort(int[,] array)
{
    int m = array.GetLength(0);
    int n = array.GetLength(1);
    int count = m * n;

    for (int jj = 0; jj < m * n; jj++)
    {
        for (int ii = 0; ii < count - 1; ii++)
        {
            int i1 = ii / n;
            int j1 = ii % n;
            int i2 = (ii + 1) / n;
            int j2 = (ii + 1) % n;

            if (array[i1, j1] > array[i2, j2])
            {
                int cur = array[i1, j1];
                array[i1, j1] = array[i2, j2];
                array[i2, j2] = cur;
            }
        }
        count--;
    }
}

void FrequencyDict(int[,] array)
{
    int m = array.GetLength(0);
    int n = array.GetLength(1);

    int num = array[0, 0];
    int count = 1;

    for (int ii = 0; ii < m * n - 1; ii++)
    {
        int i1 = ii / n;
        int j1 = ii % n;
        int i2 = (ii + 1) / n;
        int j2 = (ii + 1) % n;

        if (array[i1, j1] == array[i2, j2])
        {
            count++;
        }
        else
        {
            Console.WriteLine($"Number {num} - {count} times.");
            num = array[i2, j2];
            count = 1;
        }
    }
    Console.WriteLine($"Number {num} - {count} times.");
}

Console.WriteLine("Enter the dimension m*n of array: ");
string[] str = Console.ReadLine().Split(" ");

int m = Convert.ToInt32(str[0]);
int n = Convert.ToInt32(str[1]);

int[,] arr = CreateArray(m, n, 0, 9);
PrintArray(arr);

BubbleSort(arr);
PrintArray(arr);

FrequencyDict(arr);


