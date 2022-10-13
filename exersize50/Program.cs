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


double[,] NewArray(int m, int n) {
    double[,] array = new double[m,n];

    for (int i = 0; i < m; i++) {
        for (int j = 0; j < n; j++) {
            array[i, j] = GetRandomNumber(-10, 10);
        }
    }
    PrintArray(array);
    return array;
}

double[,] array = NewArray(4,5);

void FindElem(int y, int x, double[,] array) {
    if (x < array.GetLength(1) || y < array.GetLength(0)) {
        Console.WriteLine(array[y,x]);
    } else {
        Console.WriteLine("Число с таким адресом в массиве нет");
    }
}

FindElem(3,4,array);
