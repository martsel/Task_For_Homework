// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int [] array = new int [6];
Random rand = new Random();
for(int i = 0; i < array.Length; i++)
{
    array[i] = rand.Next(100, 1000);
    Console.WriteLine(array[i]);
}

int summ = 0;
for(int i = 1; i < array.Length; i++)
{
    if ((array[i] % 2) == 0)
    {
        summ++;
    }
}
 Console.Write("sum");
    Console.WriteLine(summ);