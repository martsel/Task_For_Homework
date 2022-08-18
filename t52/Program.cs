Console.WriteLine("Задайте размерность двумерного массива m * n");
Console.Write("Введите m =  ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите n =  ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] matrix = new int[m, n];
Random ran = new Random();
 double midle = 0;
for (int i = 0; i < n; i++)
{
 
  for (int j = 0; j < m; j++)
  {
    matrix[i,j] = ran.Next (0,10);
    midle += matrix[i, j];
    Console.Write(matrix[i,j] + " , ");
  }
  midle = Math.Round(midle / m);
  Console.WriteLine($"№ {i+1} = {midle}");
}

