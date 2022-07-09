Console.Write("Введите число N:   ");
int N = Convert.ToInt32(Console.ReadLine());
int count = -N;
while(count <= N) {
    Console.WriteLine(count);
    count++;
}