// Задача 47. Задайте двумерный массив размером m×n, 
// заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9


internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Задайте размерность двумерного массива m * n");
        Console.Write("Введите m =  ");
        int m = Convert.ToInt32(Console.ReadLine());

        Console.Write("Введите n =  ");
        int n = Convert.ToInt32(Console.ReadLine());
        double[,]a = new double[m,n];
        Random random = new Random();
        for (int i = 0; i < m; i++)
        {
             for (int j = 0; j < n; j++){
                a[i, j] = random.NextDouble()*100;
                Console.Write("{0,0:F2} ", a[i, j]);
             }
             Console.WriteLine();
        }



    }
}


