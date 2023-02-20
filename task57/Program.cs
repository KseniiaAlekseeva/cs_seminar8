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

void SortArray(int[,] array)
{

}

void FrequencyDict(int[,] array)
{
    int m = array.GetLength(0);
    int n = array.GetLength(1);
    int mn = m * n;



    for (int ii = 0; ii < m * n; ii++)
    {
        int i = ii / n;
        int j = ii % n;
        Console.WriteLine($"{ii} --- i {i} j {j}");

        int temp = array[i, j];
        int count = 0;
        for (int k = 0; k < m * n; k++)
        {
            int iii = k / n;
            int jjj = k % n;
            if (temp == array[iii, jjj])
                count++;
        }
        Console.WriteLine($"Element {temp} - {count}.");

        // for (int i = 0; i < m; i++)
        // {
        //     for (int j = 0; j < n; j++)
        //     {
        //         (i * m) + j;
        //         temp = array[i, j];
        //         for (int k = 0; k < count + 1; k++)
        //         {
        //             flag = false;
        //             if (freq[k, 0] == array[i, j])
        //             {
        //                 freq[k, 1] += 1;
        //                 flag = true;
        //             }
        //             else
        //             {
        //                 freq[count, 0] = array[i, j];
        //                 count += 1;
        //             }
        //         }
        //     }
        // }
        //return freq;
    }
}
Console.WriteLine("Enter the dimension m*n of array: ");
string[] str = Console.ReadLine().Split(" ");

int m = Convert.ToInt32(str[0]);
int n = Convert.ToInt32(str[1]);

int[,] arr = CreateArray(m, n, 0, 9);
PrintArray(arr);

FrequencyDict(arr);


