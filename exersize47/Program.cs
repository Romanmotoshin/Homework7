double GetRandomNumber(double minimum, double maximum)
{
return Math.Round(new Random().NextDouble() * (maximum - minimum) + minimum,1);
}

void PrintArray(double[,] inArray)
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


void exer47(int m, int n) {
    double[,] array = new double[m,n];

    for (int i = 0; i < m; i++) {
        for (int j = 0; j < n; j++) {
            array[i, j] = GetRandomNumber(-10, 10);
        }
    }
    PrintArray(array);
}

exer47(4,5);