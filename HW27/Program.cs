// Задача 27: Напишите программу, которая принимает на вход число 
// и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Write("Введите число  ");
int number = int.Parse(Console.ReadLine());
int sum = 0;

while(number > 0)
{
    sum = sum + number % 10;
    number /= 10;
}
Console.WriteLine("Результат = {sum}");
// Console.WriteLine(sum);







// Console.Write("Введите число А  ");
// int A = Convert.ToInt32(Console.ReadLine());
// int sum = 0;

// while(A>=10)
// {
//     sum = A % 10;
//     A = A/10;
// }
// Console.WriteLine($"Результат =  {sum}" );
// Console.WriteLine(sum);


// Console.Write("Введите число А  ");
// int A = Convert.ToInt32(Console.ReadLine());

// static void Main(string[] args)
// {
//     Console.Write("Введите число А  ");
//     int A = Convert.ToInt32(Console.ReadLine());
//     int sum = Foo(A);
// }

// static int Foo(int A)
// {
//     int sum = 1;
//     while (A>=0)
//     {
//         sum += A % 10;
//         A = A/10;
//     }
//     return sum;
// }

// // Console.WriteLine($"Результат =  {sum}" );
