// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.



void PrintMatrix(int[,]  matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i,j] + " ");
        }
        Console.WriteLine();
    }
}


int[,] FillRandomDoubleArray(int lines = 3, int columns = 4, int leftRange = -10, int rethRange = 10)
{
    int[,] randomArray = new int[lines, columns];
    Random rand = new Random();
    for (int i = 0; i < randomArray.GetLength(0); i++)
    {
        for (int j = 0; j < randomArray.GetLength(1); j++)
        {
            randomArray[i,j] = rand.Next(leftRange, rethRange + 1);
        }
    }
    return randomArray;
}

int[,] array = FillRandomDoubleArray();
double[] averageColumsArray = new double [array.GetLength(1)];
for (int j = 0; j < array.GetLength(1); j++)
{
    int sum = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        sum = sum + array[i,j];
        averageColumsArray[j] = Math.Round((Convert.ToDouble(sum)/array.GetLength(0)), 1);
    }
}
PrintMatrix(array);

Console.WriteLine();
Console.Write($" среднееарифметическое по столбцам "+ string.Join("; ", averageColumsArray));




// int[,] matrix = new int[m, n];
// Random ran = new Random();
//  double midle = 0;
// for (int i = 0; i < n; i++)
// {
 
//   for (int j = 0; j < m; j++)
//   {
//     matrix[i,j] = ran.Next (0,10);
//     midle += matrix[i, j];
//     Console.Write(matrix[i,j] + " , ");
//   }
//   midle = Math.Round(midle / m);
//   Console.WriteLine($"№ {i+1} = {midle}");
// }

