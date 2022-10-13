int GetRandomNumber(int minimum, int maximum)
{
return new Random().Next(minimum, maximum);
}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i,j]}\t");
        }
        Console.WriteLine();
    }
}


int[,] NewArray(int m, int n) {
    int[,] array = new int[m,n];

    for (int i = 0; i < m; i++) {
        for (int j = 0; j < n; j++) {
            array[i, j] = GetRandomNumber(1, 99);
        }
    }
    PrintArray(array);
    return array;
}

int[,] array = NewArray(4,5);

void GetAverage(int[,] array) {
    Console.WriteLine("Среднее арифметическое каждого столбца:");
    for(int i = 0; i < array.GetLength(1); i++) {
        double sum = 0;
        for(int j = 0; j < array.GetLength(0); j++) {
            sum += array[j, i];
        }
        Console.Write($"{sum/array.GetLength(0)}\t");
    }
}

GetAverage(array);
